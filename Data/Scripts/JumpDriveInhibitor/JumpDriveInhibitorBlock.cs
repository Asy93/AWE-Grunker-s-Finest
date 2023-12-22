using Sandbox.Game;
using Sandbox.ModAPI;
using SpaceEngineers.Game.ModAPI;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VRage.Game.Components;
using VRage.Game.ModAPI;
using VRage.ObjectBuilders;
using VRageMath;

namespace GrunkQuest
{
    [MyEntityComponentDescriptor(typeof(Sandbox.Common.ObjectBuilders.MyObjectBuilder_Beacon), false, "JumpInhibitor")]
    public class InhibRewrite : MyGameLogicComponent
    {
        public const double INHIB_ACTIVE_TIME = 45.0;
        public const double INHIB_COOLDOWN_TIME = 135.0;

        public InhibitorState InhibState;

        private double _time;
        private IMyBeacon _inhibitorBlock;
        private readonly List<IMyFunctionalBlock> _inhibitedBlocks = new List<IMyFunctionalBlock>();

        public override void Init(MyObjectBuilder_EntityBase objectBuilder)
        {
            _inhibitorBlock = Entity as IMyBeacon;
            NeedsUpdate |= VRage.ModAPI.MyEntityUpdateEnum.EACH_10TH_FRAME;

            _inhibitorBlock.AppendingCustomInfo += _inhibitorBlock_AppendingCustomInfo;
            _inhibitorBlock.IsWorkingChanged += _inhibitorBlock_IsWorkingChanged;
        }

        private void _inhibitorBlock_IsWorkingChanged(IMyCubeBlock obj)
        {
            if (!_inhibitorBlock.IsWorking && InhibState == InhibitorState.Active)
                Cooldown();
        }

        public override void Close()
        {
            _inhibitorBlock.AppendingCustomInfo -= _inhibitorBlock_AppendingCustomInfo;
            _inhibitorBlock.IsWorkingChanged -= _inhibitorBlock_IsWorkingChanged;
        }

        private void _inhibitorBlock_AppendingCustomInfo(IMyTerminalBlock block, StringBuilder sb)
        {
            sb.Append("inhibitor state: ");
            sb.AppendLine(InhibState.ToString());

            if (InhibState == InhibitorState.Ready) return;

            double neg = InhibState == InhibitorState.Active ? INHIB_ACTIVE_TIME : INHIB_COOLDOWN_TIME;
            double timeLeft = neg - _time;

            sb.Append("time until ");
            if (InhibState == InhibitorState.Active)
                sb.Append("inhibitor overload");
            else sb.Append("inhibitor cooled down");

            sb.AppendLine($" {timeLeft.ToString("0.00")}s.");
        }

        public override void UpdateAfterSimulation10()
        {
            if (!MyAPIGateway.Multiplayer.IsServer)
            {
                _inhibitorBlock.RefreshCustomInfo();
                return;
            }

            foreach (var block in _inhibitedBlocks)
            {
                block.EnabledChanged -= PreventReactivation;
            }
            _inhibitedBlocks.Clear();

            if (InhibState == InhibitorState.Ready && _inhibitorBlock.IsWorking)
                InhibState = InhibitorState.Active;

            if (InhibState == InhibitorState.Ready)
                _time = 0;
            else _time += 1d / 60d * 10;

            if (InhibState == InhibitorState.Cooldown)
                _inhibitorBlock.Enabled = false;

            if (InhibState == InhibitorState.Active && _time > INHIB_ACTIVE_TIME)
                Cooldown();

            if (InhibState == InhibitorState.Cooldown && _time > INHIB_COOLDOWN_TIME)
            {
                _time = 0;
                InhibState = InhibitorState.Ready;
                //MyVisualScriptLogicProvider.ShowNotificationToAll($"Inhibitor has cooled down!", 4816);
                ShittyNotification("Inhibitor has cooled down!");
            }

            _inhibitorBlock.RefreshCustomInfo();

            if (InhibState == InhibitorState.Ready || !_inhibitorBlock.IsWorking) return;

            var aabb = new BoundingSphereD(_inhibitorBlock.WorldMatrix.Translation, _inhibitorBlock.Radius);
            var inhibbedEnts = MyAPIGateway.Entities.GetEntitiesInSphere(ref aabb);
            inhibbedEnts.Add(_inhibitorBlock.CubeGrid);

            for (int i = 0; i < inhibbedEnts.Count; i++)
            {
                var grid = inhibbedEnts[i] as IMyCubeGrid;
                if (grid == null) continue;

                grid.GetBlocks(null, (_) =>
                {
                    var funcBlock = _.FatBlock as IMyFunctionalBlock;

                    if (funcBlock == null)
                        return false;

                    if (funcBlock is IMyVirtualMass || funcBlock is IMyJumpDrive || (grid.IsStatic && funcBlock is IMyProjector))
                    {
                        funcBlock.Enabled = false;
                        funcBlock.EnabledChanged += PreventReactivation;
                        _inhibitedBlocks.Add(funcBlock);
                    }

                    return false;
                });
            }
        }
        private static void PreventReactivation(IMyTerminalBlock block)
        {
            var functional = block as IMyFunctionalBlock;
            if (functional == null) return;

            if (functional.Enabled) functional.Enabled = false;
        }
        public void Cooldown()
        {
            _time = 0;
            InhibState = InhibitorState.Cooldown;
            //MyVisualScriptLogicProvider.ShowNotificationToAll($"Inhibitor has overloaded! Cooled  down in {INHIB_COOLDOWN_TIME.ToString("0.00")} seconds!", 4816);
            ShittyNotification($"Inhibitor has overloaded! Cooled  down in {INHIB_COOLDOWN_TIME.ToString("0.00")} seconds!");
        }
        public void ShittyNotification(string payload)
        {
            var aabb = new BoundingSphereD(_inhibitorBlock.WorldMatrix.Translation, _inhibitorBlock.Radius);
            var characters = MyAPIGateway.Entities.GetEntitiesInSphere(ref aabb).OfType<IMyCharacter>();
            foreach (var lol in characters)
                MyVisualScriptLogicProvider.ShowNotification(payload, 4816, "Red", lol.ControllerInfo.ControllingIdentityId);
        }
    }
    public enum InhibitorState { Ready, Active, Cooldown }
}
