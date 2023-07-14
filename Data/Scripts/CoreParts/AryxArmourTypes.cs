using static Scripts.Structure;
using static Scripts.Structure.ArmorDefinition.ArmorType;
namespace Scripts {   
    partial class Parts {
        // Don't edit above this line
        ArmorDefinition AryxHeavierTurretArmour => new ArmorDefinition
        {
            SubtypeIds = new[] {
                "ARYXTyphoonCannon",
                "ARYXReaperPulseCannon",
                "ARYXMagnetarCannon",
                "ARYXGaussTurret",
            },
            EnergeticResistance = 1.5f, //Resistance to Energy damage. 0.5f = 200% damage, 2f = 50% damage
            KineticResistance = 1.5f, //Resistance to Kinetic damage. Leave these as 1 for no effect
            Kind = Heavy, //Heavy, Light, NonArmor - which ammo damage multipliers to apply
        };
        ArmorDefinition AryxHeavyTurretArmour => new ArmorDefinition
        {
            SubtypeIds = new[] {
                "ARYXMissileBattery",
                "ARYXQuasarCannon",
                "ARYXHurricaneCannon",
                "ARYXPlasmaBeamCannon",
            },
            EnergeticResistance = 1.25f, //Resistance to Energy damage. 0.5f = 200% damage, 2f = 50% damage
            KineticResistance = 1.25f, //Resistance to Kinetic damage. Leave these as 1 for no effect
            Kind = Heavy, //Heavy, Light, NonArmor - which ammo damage multipliers to apply
        };
        ArmorDefinition GrunkerArmourFix => new ArmorDefinition
        {
            SubtypeIds = new[] {
                "HXL_1x"
                "HXL_1xFrame"
                "HXL_1xMount"
                "HXL_1xPlatform"
                "HXL_Block"
                "HXL_BlockDetail"
                "HXL_BlockHazard"
                "HXL_BlockInvCorner"
                "HXL_BlockSlope"
                "HXL_BlockCorner"
                "HXL_BlockFrame"
                "HXL_HalfBlock"
                "HXL_HalfBlockCorner"
                "HXL_HalfCornerBase"
                "HXL_HalfCornerTip"
                "HXL_HalfCornerBaseInv"
                "HXL_HalfCornerTipInv"
                "HXL_HalfSlopeBase"
                "HXL_HalfSlopeTip"
                "HXL_PassageCorner"
                "HXL_Passage"
                "HXL_Hip"
                "HXL_Passage"
            },
            EnergeticResistance = 1f, //Resistance to Energy damage. 0.5f = 200% damage, 2f = 50% damage
            KineticResistance = 1f, //Resistance to Kinetic damage. Leave these as 1 for no effect
            Kind = Heavy, //Heavy, Light, NonArmor - which ammo damage multipliers to apply
        };
        ArmorDefinition GrunkerArmourFixPt2 => new ArmorDefinition
        {
            SubtypeIds = new[] {
                "XL_1x"
                "XL_1xFrame"
                "XL_1xMount"
                "XL_1xPlatform"
                "XL_Block"
                "XL_BlockDetail"
                "XL_BlockHazard"
                "XL_BlockInvCorner"
                "XL_BlockSlope"
                "XL_BlockCorner"
                "XL_BlockFrame"
                "XL_HalfBlock"
                "XL_HalfBlockCorner"
                "XL_HalfCornerBase"
                "XL_HalfCornerTip"
                "XL_HalfCornerBaseInv"
                "XL_HalfCornerTipInv"
                "XL_HalfSlopeBase"
                "XL_HalfSlopeTip"
                "XL_PassageCorner"
                "XL_Passage"
                "XL_Hip"
                "XL_Passage"
            },
            EnergeticResistance = 1f, //Resistance to Energy damage. 0.5f = 200% damage, 2f = 50% damage
            KineticResistance = 1f, //Resistance to Kinetic damage. Leave these as 1 for no effect
            Kind = Light, //Heavy, Light, NonArmor - which ammo damage multipliers to apply
        };
        ArmorDefinition GrunkerArmourFixPt3 => new ArmorDefinition
        {
            SubtypeIds = new[] {

                "MA_HeavyBridge_B1B"
                "MA_HeavyBridge_B1T"
                "MA_HeavyBridge_C1B"
                "MA_HeavyBridge_C1T"
                "MA_HeavyBridge_D1B"
                "MA_HeavyBridge_D1T"
                "MA_HeavyBridge_B2B"
                "MA_HeavyBridge_B2B_shorty"
                "MA_HeavyBridge_B2T"                
                "MA_HeavyBridge_C2B"
                "MA_HeavyBridge_C2T"
                "MA_HeavyBridge_D2B"
                "MA_HeavyBridge_D2B_shorty"
                "MA_HeavyBridge_D2T"
                "MA_HeavyBridge_A3B"
                "MA_HeavyBridge_A3T"
                "MA_HeavyBridge_B3B"
                "MA_HeavyBridge_B3T"
                "MA_HeavyBridge_C3B"
                "MA_HeavyBridge_C3T"                
                "MA_HeavyBridge_D3B"
                "MA_HeavyBridge_D3T"
                "MA_HeavyBridge_E3B"
                "MA_HeavyBridge_E3T"
                "MA_HeavyBridge_A4"
                "MA_HeavyBridge_C4B"
                "MA_HeavyBridge_C4T"
                "MA_HeavyBridge_E4"

                "MA_HB_Conveyor"
                "MA_HB_Convtube_slab"
                "MA_HB_Window_end_L"
                "MA_HB_Window_end_R"
                "MA_HB_Window_end_L_Conv"
                "MA_HB_Window_end_R_Conv"
                "MA_HB_Window_end_R_Med"
                "MA_HB_Window_straight"
                "MA_HB_Window_corner"
                "MA_HB_Window_in_corner"
                "MA_HB_HalfSteps"
                "MA_HB_Slab"
                "MA_HB_SlabSteps"
                "MA_HB_Window_Top"

                "MA_HB_Railing_Single"
                "MA_HB_Railing_Double"
                "MA_HB_Railing_Corner"
                "MA_HB_Railing_Triple"

                "MA_HB_HalfSteps_Drail"
                "MA_HB_HalfSteps_Lrail"
                "MA_HB_HalfSteps_Rrail"

                "MA_HB_Window_EndTableL"
                "MA_HB_Window_EndTableR"
                "MA_HB_Window_Workstation"

                "MA_HB_Programmable"

            },
            EnergeticResistance = 1f, //Resistance to Energy damage. 0.5f = 200% damage, 2f = 50% damage
            KineticResistance = 1f, //Resistance to Kinetic damage. Leave these as 1 for no effect
            Kind = NonArmor, //Heavy, Light, NonArmor - which ammo damage multipliers to apply
        };        
    }
