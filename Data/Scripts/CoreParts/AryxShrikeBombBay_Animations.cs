﻿using System.Collections.Generic;
using static Scripts.Structure.WeaponDefinition;
using static Scripts.Structure.WeaponDefinition.AnimationDef;
using static Scripts.Structure.WeaponDefinition.AnimationDef.PartAnimationSetDef.EventTriggers;
using static Scripts.Structure.WeaponDefinition.AnimationDef.RelMove.MoveType;
using static Scripts.Structure.WeaponDefinition.AnimationDef.RelMove;
namespace Scripts
{ // Don't edit above this line
    partial class Parts
    {
        private AnimationDef AryxShrikeAnims => new AnimationDef
        {

            //These are the animation sets the weapon uses in various states.
            AnimationSets = new[]
            {   //Region is used for organisation as it creates a collapsible tag.
				#region Barrels Animations

                new PartAnimationSetDef()
                {
                    SubpartId = Names("leftDoor"), //Remember to remove subpart_ from these names!
                    BarrelId = "muzzle_projectile_1", //Trigger anim when this muzzle does something.
                    StartupFireDelay = 0, //Delay in ticks until anim starts.
                    AnimationDelays = Delays(FiringDelay: 0, ReloadingDelay: 0, OverheatedDelay: 0, TrackingDelay: 0, LockedDelay: 0, OnDelay: 0, OffDelay: 0, BurstReloadDelay: 0, OutOfAmmoDelay: 0, PreFireDelay: 0),//Delay before animation starts
                    Reverse = Events(),
                    Loop = Events(), //Don't touch these.
                    EventMoveSets = new Dictionary<PartAnimationSetDef.EventTriggers, RelMove[]>
                    {

                        [PreFire] =
                            new[] //Firing, Reloading, Overheated, Tracking, On, Off, BurstReload, OutOfAmmo, PreFire define a new[] for each
                            {
                               new RelMove //This is an animation block, and moves a subpart named subpart_leftRail -0.2 on the X axis.
                                {
                                    CenterEmpty = "",
                                    TicksToMove = 15, //number of ticks to complete motion, 60 = 1 second
                                    MovementType = Linear, //Linear,ExpoDecay,ExpoGrowth,Delay,Show, //instant or fade Hide, //instant or fade
                                    LinearPoints = new XYZ[0],
                                    Rotation = Transformation(0, 0, -90), //degrees
                                    RotAroundCenter = Transformation(0, 0, 0), //degrees
                                },
                               new RelMove //This is an animation block, and moves a subpart named subpart_leftRail -0.2 on the X axis.
                                {
                                    CenterEmpty = "",
                                    TicksToMove = 30, //number of ticks to complete motion, 60 = 1 second
                                    MovementType = Linear, //Linear,ExpoDecay,ExpoGrowth,Delay,Show, //instant or fade Hide, //instant or fade
                                    LinearPoints = new XYZ[0],
                                    Rotation = Transformation(0, 0, 0), //degrees
                                    RotAroundCenter = Transformation(0, 0, 0), //degrees
                                },
                            },

                    }
                },

                new PartAnimationSetDef()
                {
                    SubpartId = Names("leftDoor"), //Remember to remove subpart_ from these names!
                    BarrelId = "muzzle_projectile_1", //Trigger anim when this muzzle does something.
                    StartupFireDelay = 60, //Delay in ticks until anim starts.
                    AnimationDelays = Delays(FiringDelay: 0, ReloadingDelay: 0, OverheatedDelay: 0, TrackingDelay: 0, LockedDelay: 0, OnDelay: 0, OffDelay: 0, BurstReloadDelay: 0, OutOfAmmoDelay: 0, PreFireDelay: 0),//Delay before animation starts
                    Reverse = Events(),
                    Loop = Events(), //Don't touch these.
                    EventMoveSets = new Dictionary<PartAnimationSetDef.EventTriggers, RelMove[]>
                    {

                        [Firing] =
                            new[] //Firing, Reloading, Overheated, Tracking, On, Off, BurstReload, OutOfAmmo, PreFire define a new[] for each
                            {
                               new RelMove //This is an animation block, and moves a subpart named subpart_leftRail -0.2 on the X axis.
                                {
                                    CenterEmpty = "",
                                    TicksToMove = 60, //number of ticks to complete motion, 60 = 1 second
                                    MovementType = Linear, //Linear,ExpoDecay,ExpoGrowth,Delay,Show, //instant or fade Hide, //instant or fade
                                    LinearPoints = new XYZ[0],
                                    Rotation = Transformation(0, 0, 0), //degrees
                                    RotAroundCenter = Transformation(0, 0, 0), //degrees
                                },
                               new RelMove
                                {
                                    CenterEmpty = "",
                                    TicksToMove = 30, //number of ticks to complete motion, 60 = 1 second
                                    MovementType = Linear, //Linear,ExpoDecay,ExpoGrowth,Delay,Show, //instant or fade Hide, //instant or fade
                                    LinearPoints = new XYZ[0],
                                    Rotation = Transformation(0, 0, 90), //degrees
                                    RotAroundCenter = Transformation(0, 0, 0), //degrees
                                },
                            },
                    }
                },
                
                ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                new PartAnimationSetDef()
                {
                    SubpartId = Names("rightDoor"), //Remember to remove subpart_ from these names!
                    BarrelId = "muzzle_projectile_1", //Trigger anim when this muzzle does something.
                    StartupFireDelay = 0, //Delay in ticks until anim starts.
                    AnimationDelays = Delays(FiringDelay: 0, ReloadingDelay: 0, OverheatedDelay: 0, TrackingDelay: 0, LockedDelay: 0, OnDelay: 0, OffDelay: 0, BurstReloadDelay: 0, OutOfAmmoDelay: 0, PreFireDelay: 0),//Delay before animation starts
                    Reverse = Events(),
                    Loop = Events(), //Don't touch these.
                    EventMoveSets = new Dictionary<PartAnimationSetDef.EventTriggers, RelMove[]>
                    {

                        [PreFire] =
                            new[] //Firing, Reloading, Overheated, Tracking, On, Off, BurstReload, OutOfAmmo, PreFire define a new[] for each
                            {
                               new RelMove
                                {
                                    CenterEmpty = "",
                                    TicksToMove = 15, //number of ticks to complete motion, 60 = 1 second
                                    MovementType = Linear, //Linear,ExpoDecay,ExpoGrowth,Delay,Show, //instant or fade Hide, //instant or fade
                                    LinearPoints = new XYZ[0],
                                    Rotation = Transformation(0, 0, 90), //degrees
                                    RotAroundCenter = Transformation(0, 0, 0), //degrees
                                },
                               new RelMove
                                {
                                    CenterEmpty = "",
                                    TicksToMove = 30, //number of ticks to complete motion, 60 = 1 second
                                    MovementType = Linear, //Linear,ExpoDecay,ExpoGrowth,Delay,Show, //instant or fade Hide, //instant or fade
                                    LinearPoints = new XYZ[0],
                                    Rotation = Transformation(0, 0, 0), //degrees
                                    RotAroundCenter = Transformation(0, 0, 0), //degrees
                                },
                            },

                    }
                },

                new PartAnimationSetDef()
                {
                    SubpartId = Names("rightDoor"), //Remember to remove subpart_ from these names!
                    BarrelId = "muzzle_projectile_1", //Trigger anim when this muzzle does something.
                    StartupFireDelay = 60, //Delay in ticks until anim starts.
                    AnimationDelays = Delays(FiringDelay: 0, ReloadingDelay: 0, OverheatedDelay: 0, TrackingDelay: 0, LockedDelay: 0, OnDelay: 0, OffDelay: 0, BurstReloadDelay: 0, OutOfAmmoDelay: 0, PreFireDelay: 0),//Delay before animation starts
                    Reverse = Events(),
                    Loop = Events(), //Don't touch these.
                    EventMoveSets = new Dictionary<PartAnimationSetDef.EventTriggers, RelMove[]>
                    {

                        [Firing] =
                            new[] //Firing, Reloading, Overheated, Tracking, On, Off, BurstReload, OutOfAmmo, PreFire define a new[] for each
                            {
                               new RelMove
                                {
                                    CenterEmpty = "",
                                    TicksToMove = 60, //number of ticks to complete motion, 60 = 1 second
                                    MovementType = Linear, //Linear,ExpoDecay,ExpoGrowth,Delay,Show, //instant or fade Hide, //instant or fade
                                    LinearPoints = new XYZ[0],
                                    Rotation = Transformation(0, 0, 0), //degrees
                                    RotAroundCenter = Transformation(0, 0, 0), //degrees
                                },
                               new RelMove
                                {
                                    CenterEmpty = "",
                                    TicksToMove = 30, //number of ticks to complete motion, 60 = 1 second
                                    MovementType = Linear, //Linear,ExpoDecay,ExpoGrowth,Delay,Show, //instant or fade Hide, //instant or fade
                                    LinearPoints = new XYZ[0],
                                    Rotation = Transformation(0f, 0, -90), //degrees
                                    RotAroundCenter = Transformation(0, 0, 0), //degrees
                                },
                            },
                    }
                },

                new PartAnimationSetDef()
                {
                    SubpartId = Names("arms"), //Remember to remove subpart_ from these names!
                    BarrelId = "muzzle_projectile_1", //Trigger anim when this muzzle does something.
                    StartupFireDelay = 0, //Delay in ticks until anim starts.
                    AnimationDelays = Delays(FiringDelay: 0, ReloadingDelay: 0, OverheatedDelay: 0, TrackingDelay: 0, LockedDelay: 0, OnDelay: 0, OffDelay: 0, BurstReloadDelay: 0, OutOfAmmoDelay: 0, PreFireDelay: 0),//Delay before animation starts
                    Reverse = Events(),
                    Loop = Events(), //Don't touch these.
                    EventMoveSets = new Dictionary<PartAnimationSetDef.EventTriggers, RelMove[]>
                    {

                        [PreFire] =
                            new[] //Firing, Reloading, Overheated, Tracking, On, Off, BurstReload, OutOfAmmo, PreFire define a new[] for each
                            {

                               new RelMove
                                {
                                    CenterEmpty = "",
                                    TicksToMove = 30, //number of ticks to complete motion, 60 = 1 second
                                    MovementType = Linear, //Linear,ExpoDecay,ExpoGrowth,Delay,Show, //instant or fade Hide, //instant or fade
                                    LinearPoints = new[]
                                    {
                                        Transformation(0, -0.675f, 0), //linear movement in XYZ axes.
                                    },
                                    Rotation = Transformation(0, 0, 0), //degrees
                                    RotAroundCenter = Transformation(0, 0, 0), //degrees
                                },
                               new RelMove
                                {
                                    CenterEmpty = "",
                                    TicksToMove = 15, //number of ticks to complete motion, 60 = 1 second
                                    MovementType = Delay, //Linear,ExpoDecay,ExpoGrowth,Delay,Show, //instant or fade Hide, //instant or fade
                                    LinearPoints = new[]
                                    {
                                        Transformation(0f, 0, 0f), //linear movement in XYZ axes.
                                    },
                                    Rotation = Transformation(0, 0, 0), //degrees
                                    RotAroundCenter = Transformation(0, 0, 0), //degrees
                                },
                               new RelMove
                                {
                                    CenterEmpty = "",
                                    TicksToMove = 30, //number of ticks to complete motion, 60 = 1 second
                                    MovementType = Linear, //Linear,ExpoDecay,ExpoGrowth,Delay,Show, //instant or fade Hide, //instant or fade
                                    LinearPoints = new[]
                                    {
                                        Transformation(0f, 0.675f, 0), //linear movement in XYZ axes.
                                    },
                                    Rotation = Transformation(0, 0, 0), //degrees
                                    RotAroundCenter = Transformation(0, 0, 0), //degrees
                                },
                            },

                    }

                },


                new PartAnimationSetDef()
                {
                    SubpartId = Names("bomb"), //Remember to remove subpart_ from these names!
                    BarrelId = "muzzle_projectile_1", //Trigger anim when this muzzle does something.
                    StartupFireDelay = 0, //Delay in ticks until anim starts.
                    AnimationDelays = Delays(FiringDelay: 0, ReloadingDelay: 0, OverheatedDelay: 0, TrackingDelay: 0, LockedDelay: 0, OnDelay: 0, OffDelay: 0, BurstReloadDelay: 0, OutOfAmmoDelay: 0, PreFireDelay: 0),//Delay before animation starts
                    Reverse = Events(),
                    Loop = Events(), //Don't touch these.
                    EventMoveSets = new Dictionary<PartAnimationSetDef.EventTriggers, RelMove[]>
                    {

                        [Firing] =
                            new[] //Firing, Reloading, Overheated, Tracking, On, Off, BurstReload, OutOfAmmo, PreFire define a new[] for each
                            {

                               new RelMove
                                {
                                    CenterEmpty = "",
                                    TicksToMove = 1, //number of ticks to complete motion, 60 = 1 second
                                    MovementType = Hide, //Linear,ExpoDecay,ExpoGrowth,Delay,Show, //instant or fade Hide, //instant or fade
                                    LinearPoints = new[]
                                    {
                                        Transformation(0f, 0, 0f), //linear movement in XYZ axes.
                                    },
                                    Rotation = Transformation(0, 0, 0), //degrees
                                    RotAroundCenter = Transformation(0, 0, 0), //degrees
                                },
                               new RelMove
                                {
                                    CenterEmpty = "",
                                    TicksToMove = 120, //number of ticks to complete motion, 60 = 1 second
                                    MovementType = Delay, //Linear,ExpoDecay,ExpoGrowth,Delay,Show, //instant or fade Hide, //instant or fade
                                    LinearPoints = new[]
                                    {
                                        Transformation(0f, 0, 0f), //linear movement in XYZ axes.
                                    },
                                    Rotation = Transformation(0, 0, 0), //degrees
                                    RotAroundCenter = Transformation(0, 0, 0), //degrees
                                },
                               new RelMove
                                {
                                    CenterEmpty = "",
                                    TicksToMove = 1, //number of ticks to complete motion, 60 = 1 second
                                    MovementType = Show, //Linear,ExpoDecay,ExpoGrowth,Delay,Show, //instant or fade Hide, //instant or fade
                                    LinearPoints = new[]
                                    {
                                        Transformation(0f, 0, 0f), //linear movement in XYZ axes.
                                    },
                                    Rotation = Transformation(0, 0, 0), //degrees
                                    RotAroundCenter = Transformation(0, 0, 0), //degrees
                                },
                            },

                    }

                },
                #endregion
            }

        };
    }
}
