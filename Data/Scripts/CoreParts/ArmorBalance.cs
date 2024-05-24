using Sandbox.Definitions;
using Sandbox.ModAPI;
using VRage.Game;
using VRage.Game.Components;
using VRage.Utils;
using System.Collections.Generic;

// Code is based on Gauge's Balanced Deformation code, but heavily modified for more control. 
namespace enenra.ArmorBalance
{
    [MySessionComponentDescriptor(MyUpdateOrder.NoUpdate)]
    public class ArmorBalance : MySessionComponentBase
    {
        public const float lightArmorLargeDamageMod = .75f;
        public const float lightArmorLargeDeformationMod = 0.75f;
        public const float lightArmorSmallDamageMod = 0.75f;
        public const float lightArmorSmallDeformationMod = 0.75f;

        public const float heavyArmorLargeDamageMod = .9f;
        public const float heavyArmorLargeDeformationMod = .9f;
        public const float heavyArmorSmallDamageMod = .9f;
        public const float heavyArmorSmallDeformationMod = .9f;

        private bool isInit = false;

        private void DoWork()
        {
			
			HashSet<string> BlastDoorNames = new HashSet<string> { "ArmorCenter", "ArmorCorner", "ArmorInvCorner", "ArmorSide" };
			MyLog.Default.WriteLineAndConsole("Armor balancing");
            foreach (MyDefinitionBase def in MyDefinitionManager.Static.GetAllDefinitions())
            {
                MyCubeBlockDefinition blockDef = def as MyCubeBlockDefinition;

                if (blockDef == null) continue;
				
				blockDef.DamageMultiplierExplosion = 1f; //KEEEEEEEEEEEEEEEEEEN!!!!!!!!!!

				if (blockDef != null && BlastDoorNames.Contains(blockDef.BlockPairName))
				{
                    if (blockDef.CubeSize == MyCubeSize.Large)
                    {
                        blockDef.GeneralDamageMultiplier = heavyArmorLargeDamageMod;
                    }

                    if (blockDef.CubeSize == MyCubeSize.Small)
                    {
                        blockDef.GeneralDamageMultiplier = heavyArmorSmallDamageMod;
                    }
					continue;
				}
				
				bool lightArmor = blockDef.BlockPairName.Contains("Armor") && !blockDef.BlockPairName.Contains("Heavy") && !blockDef.BlockPairName.Contains("Conveyor");
				lightArmor = lightArmor || blockDef.BlockPairName.Contains("AQD_LA");
				if (lightArmor) {
                    if (blockDef.CubeSize == MyCubeSize.Large)
                    {
                        blockDef.GeneralDamageMultiplier = lightArmorLargeDamageMod;
                        blockDef.DeformationRatio = lightArmorLargeDeformationMod;
                    }

                    if (blockDef.CubeSize == MyCubeSize.Small)
                    {
                        blockDef.GeneralDamageMultiplier = lightArmorSmallDamageMod;
                        blockDef.DeformationRatio = lightArmorSmallDeformationMod;
                    }
					continue;
				}
				
				bool heavyArmor = blockDef.BlockPairName.Contains("Armor") && blockDef.BlockPairName.Contains("Heavy");
				heavyArmor = heavyArmor || blockDef.BlockPairName.Contains("AQD_HA");
				if (heavyArmor) {
                    if (blockDef.CubeSize == MyCubeSize.Large)
                    {
                        blockDef.GeneralDamageMultiplier = heavyArmorLargeDamageMod;
                        blockDef.DeformationRatio = heavyArmorLargeDeformationMod;
                    }

                    if (blockDef.CubeSize == MyCubeSize.Small)
                    {
                        blockDef.GeneralDamageMultiplier = heavyArmorSmallDamageMod;
                        blockDef.DeformationRatio = heavyArmorSmallDeformationMod;
                    }
					continue;
				}
			}
		}
        
        public override void Init(MyObjectBuilder_SessionComponent sessionComponent)
        {

        }

        public override void LoadData()
        {
            DoWork();  
        }
    }
}
