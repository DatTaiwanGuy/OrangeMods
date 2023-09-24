
using System;
using System.Collections;
using System.Collections.Generic;

using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Injection;

using HarmonyLib;

namespace OrangeMods;

[HarmonyPatch(typeof(CharacterControlFactory))]
class CharacterControlFactory_ {
    
    static Dictionary<EControlCharacter_, Type[]> _dictCtrl = new Dictionary<EControlCharacter_, Type[]> {
        [EControlCharacter_.X] = new Type[] {
            typeof(RMXController),
            typeof(CH001_001_Controller)
        },
        [EControlCharacter_.ZERO] = new Type[] {typeof(ZeroController)},
        [EControlCharacter_.ALIA] = new Type[] {typeof(AliaController)},
        [EControlCharacter_.BLACK_ZERO] = new Type[] {typeof(BlackZeroController)},
        [EControlCharacter_.MASSIMO] = new Type[] {typeof(MassimoController)},
        [EControlCharacter_.AXL] = new Type[] {typeof(AxlController)},
        [EControlCharacter_.FERHAM] = new Type[] {typeof(FerhamController)},
        [EControlCharacter_.ULTIMATE_ARMOR_X] = new Type[] {typeof(UltimateXController)},
        [EControlCharacter_.SECOND_ARMOR_X] = new Type[] {typeof(SecondArmorController)},
        [EControlCharacter_.VILE] = new Type[] {typeof(VavaController)},
        [EControlCharacter_.CINNAMON] = new Type[] {typeof(CinnamonController)},
        [EControlCharacter_.MARINO] = new Type[] {typeof(MarinoController)},
        [EControlCharacter_.PALLETTE] = new Type[] {typeof(PaletteController)},
        [EControlCharacter_.FIRST_ARMOR_X] = new Type[] {typeof(FirstArmorController)},
        [EControlCharacter_.WHITEDAY_ALIA] = new Type[] {typeof(AliaLoverController)},
        [EControlCharacter_.WHITEDAY_CINNAMON] = new Type[] {typeof(CinnamonLoverController)},
        [EControlCharacter_.ULTIMATE_ARMOR_X_CM] = new Type[] {typeof(CMUltimateXController)},
        [EControlCharacter_.LAYER] = new Type[] {typeof(LayerController)},
        [EControlCharacter_.ROCKMAN] = new Type[] {typeof(RockmanController)},
        [EControlCharacter_.BLUES] = new Type[] {typeof(BluesController)},
        [EControlCharacter_.SUPER_ROCKMAN] = new Type[] {typeof(SuperRockmanController)},
        [EControlCharacter_.ROLL] = new Type[] {typeof(RollController)},
        [EControlCharacter_.IRIS] = new Type[] {typeof(IrisController)},
        [EControlCharacter_.ZERO_Z] = new Type[] {typeof(RMZ_ZeroController)},
        [EControlCharacter_.LEVIATHAN] = new Type[] {typeof(LeviathanController)},
        [EControlCharacter_.AWAKENED_ZERO] = new Type[] {typeof(AwakenZeroController)},
        [EControlCharacter_.SIGMA] = new Type[] {typeof(SigmaX1Controller)},
        [EControlCharacter_.SWIMSUIT_LAYER] = new Type[] {typeof(CH041_Controller)},
        [EControlCharacter_.SWIMSUIT_ROLL] = new Type[] {typeof(CH040_Controller)},
        [EControlCharacter_.SWIMSUIT_IRIS] = new Type[] {typeof(CH042_Controller)},
        [EControlCharacter_.CIEL] = new Type[] {typeof(CH031_Controller)},
        [EControlCharacter_.AILE] = new Type[] {typeof(CH033_Controller)},
        [EControlCharacter_.PANDORA] = new Type[] {typeof(CH032_Controller)},
        [EControlCharacter_.MATSURI_ZERO] = new Type[] {typeof(CH044_Controller)},
        [EControlCharacter_.ROCK_VOLNUTT] = new Type[] {typeof(CH036_Controller)},
        [EControlCharacter_.TRON] = new Type[] {typeof(CH037_Controller)},
        [EControlCharacter_.THIRD_ARMOR_X] = new Type[] {typeof(CH043_Controller)},
        [EControlCharacter_.VAVA_HALLOWEEN] = new Type[] {typeof(CH047_Controller)},
        [EControlCharacter_.MARINO_HALLOWEEN] = new Type[] {typeof(CH045_Controller)},
        [EControlCharacter_.AILE_HALLOWEEN] = new Type[] {typeof(CH046_Controller)},
        [EControlCharacter_.COPY_X] = new Type[] {typeof(CH035_Controller)},
        [EControlCharacter_.ROCKMAN_EXE] = new Type[] {typeof(CH049_Controller)},
        [EControlCharacter_.BLUES_EXE] = new Type[] {typeof(CH050_Controller)},
        [EControlCharacter_.FORTE_EXE] = new Type[] {typeof(CH051_Controller)},
        [EControlCharacter_.OMEGA_ZERO] = new Type[] {typeof(CH034_Controller)},
        [EControlCharacter_.LEVIATHAN_XMAS] = new Type[] {typeof(CH053_Controller)},
        [EControlCharacter_.VAJURILA_FF] = new Type[] {typeof(CH052_Controller)},
        [EControlCharacter_.CINNAMON_NEWYEAR] = new Type[] {typeof(CH054_Controller)},
        [EControlCharacter_.SIGMA_X4_SECOND] = new Type[] {typeof(CH048_Controller)},
        [EControlCharacter_.MAGMA_DRAGOON] = new Type[] {typeof(CH055_Controller)},
        [EControlCharacter_.ABSOLUTE_ZERO] = new Type[] {typeof(CH019_Controller)},
        [EControlCharacter_.IRIS_VALENTINE] = new Type[] {typeof(CH058_Controller)},
        [EControlCharacter_.CIEL_VALENTINE] = new Type[] {typeof(CH057_Controller)},
        [EControlCharacter_.FORTE_GS] = new Type[] {typeof(CH059_Controller)},
        [EControlCharacter_.SAGE_HARPUIA] = new Type[] {typeof(CH060_Controller)},
        [EControlCharacter_.AXL_VALENTINE] = new Type[] {typeof(CH061_Controller)},
        [EControlCharacter_.RiCO] = new Type[] {typeof(CH039_Controller)},
        [EControlCharacter_.X_FIRE] = new Type[] {typeof(CH071_Controller)},
        [EControlCharacter_.ROCK_VOLNUTT_DARK] = new Type[] {typeof(CH064_Controller)},
        [EControlCharacter_.SERVBOT] = new Type[] {typeof(CH066_Controller)},
        [EControlCharacter_.ROLL_DASH] = new Type[] {typeof(CH065_Controller)},
        [EControlCharacter_.X_FALCOM_ARMOR] = new Type[] {typeof(CH067_Controller)},
        [EControlCharacter_.COLONEL] = new Type[] {typeof(CH070_Controller)},
        [EControlCharacter_.IRIS_ANOTHER] = new Type[] {typeof(CH069_Controller)},
        [EControlCharacter_.FORTE] = new Type[] {typeof(CH021_Controller)},
        [EControlCharacter_.ROCKMAN_TB] = new Type[] {typeof(CH072_Controller)},
        [EControlCharacter_.VAVA_MK2] = new Type[] {typeof(CH068_Controller)},
        [EControlCharacter_.ZERO_NIGHTMARE] = new Type[] {typeof(CH073_Controller)},
        [EControlCharacter_.ALIA_BRIDE] = new Type[] {typeof(CH075_Controller)},
        [EControlCharacter_.LAYER_BRIDE] = new Type[] {typeof(CH076_Controller)},
        [EControlCharacter_.MHR_MALE_HUNTER] = new Type[] {typeof(CH092_Controller)},
        [EControlCharacter_.MHR_FEMALE_HUNTER] = new Type[] {typeof(CH091_Controller)},
        [EControlCharacter_.X_REUS_ARMOR] = new Type[] {typeof(CH093_Controller)},
        [EControlCharacter_.ROCKMAN_DARK] = new Type[] {typeof(CH086_Controller)},
        [EControlCharacter_.SWIMSUIT_FERHAM] = new Type[] {typeof(CH088_Controller)},
        [EControlCharacter_.SWIMSUIT_TRON] = new Type[] {typeof(CH090_Controller)},
        [EControlCharacter_.SWIMSUIT_PALLETTE] = new Type[] {typeof(CH089_Controller)},
        [EControlCharacter_.SUPER_FORTE] = new Type[] {typeof(CH087_Controller)},
        [EControlCharacter_.X_KAI] = new Type[] {typeof(CH074_Controller)},
        [EControlCharacter_.LEVIATHAN_MATSURI] = new Type[] {typeof(CH094_Controller)},
        [EControlCharacter_.DIVE_ARMOR_X] = new Type[] {typeof(CH062_Controller)},
        [EControlCharacter_.ROCKMAN_STARFORCE] = new Type[] {typeof(CH081_Controller)},
        [EControlCharacter_.HARP_NOTE] = new Type[] {typeof(CH082_Controller)},
        [EControlCharacter_.ROGUE] = new Type[] {typeof(CH083_Controller)},
        [EControlCharacter_.SFV_RYU] = new Type[] {typeof(CH098_Controller)},
        [EControlCharacter_.SFV_CHUN_LI] = new Type[] {typeof(CH099_Controller)},
        [EControlCharacter_.SFV_AKUMA] = new Type[] {typeof(CH100_Controller)},
        [EControlCharacter_.iCO] = new Type[] {typeof(CH063_Controller)},
        [EControlCharacter_.SIGMA_HALLOWEEN] = new Type[] {typeof(CH095_Controller)},
        [EControlCharacter_.ROLL_HALLOWEEN] = new Type[] {typeof(CH096_Controller)},
        [EControlCharacter_.PANDORA_HALLOWEEN] = new Type[] {typeof(CH097_Controller)},
        [EControlCharacter_.DYNAMO] = new Type[] {typeof(CH084_Controller)},
        [EControlCharacter_.FORTE_XX] = new Type[] {typeof(CH101_Controller)},
        [EControlCharacter_.ROCKMAN_EXE_HUB_STYLE] = new Type[] {typeof(CH079_Controller)},
        [EControlCharacter_.ROLL_EXE] = new Type[] {typeof(CH080_Controller)},
        [EControlCharacter_.RICO_XMAS] = new Type[] {typeof(CH103_Controller)},
        [EControlCharacter_.CIEL_XMAS] = new Type[] {typeof(CH102_Controller)},
        [EControlCharacter_.IRIS_NEWYEAR] = new Type[] {typeof(CH104_Controller)},
        [EControlCharacter_.X_FORCE_ARMOR] = new Type[] {typeof(CH077_Controller)},
        [EControlCharacter_.DROITCLAIR] = new Type[] {typeof(CH105_Controller)},
        [EControlCharacter_.ZERO_HUNTER] = new Type[] {typeof(CH106_Controller)},
        [EControlCharacter_.IRIS_HUNTER] = new Type[] {typeof(CH107_Controller)},
        [EControlCharacter_.RiCO_VALENTINE] = new Type[] {typeof(CH108_Controller)},
        [EControlCharacter_.iCO_VALENTINE] = new Type[] {typeof(CH109_Controller)},
        [EControlCharacter_.ANJUPITOR] = new Type[] {typeof(CH110_Controller)},
        [EControlCharacter_.GATE] = new Type[] {typeof(CH085_Controller)},
        [EControlCharacter_.TRON_LAB_COAT] = new Type[] {typeof(CH111_Controller)},
        [EControlCharacter_.ViA] = new Type[] {typeof(CH113_Controller)},
        [EControlCharacter_.DIVE_RICO] = new Type[] {typeof(CH115_Controller)},
        [EControlCharacter_.X_GAEA_ARMOR] = new Type[] {typeof(CH078_Controller)},
        [EControlCharacter_.ROLL_EASTER] = new Type[] {typeof(CH116_Controller)},
        [EControlCharacter_.ERATOEIR] = new Type[] {typeof(CH112_Controller)},
        [EControlCharacter_.NANA] = new Type[] {typeof(CH022_Controller)},
        [EControlCharacter_.ZERO_Q] = new Type[] {typeof(CH117_Controller)},
        [EControlCharacter_.SECOND_ARMOR_X_Q] = new Type[] {typeof(CH118_Controller)},
        [EControlCharacter_.LIGHT_MARTIALIST] = new Type[] {typeof(CH119_Controller)},
        [EControlCharacter_.FORTE_CROSS_ROCKMAN] = new Type[] {typeof(CH120_Controller)},
        [EControlCharacter_.iCO_SWIMSUIT] = new Type[] {typeof(CH121_Controller)},
        [EControlCharacter_.CIEL_SWIMSUIT] = new Type[] {typeof(CH122_Controller)},
        [EControlCharacter_.DIVE_ARMOR_ZERO] = new Type[] {typeof(CH123_Controller)},
        [EControlCharacter_.AILE_ZX] = new Type[] {typeof(CH124_Controller)},
        [EControlCharacter_.DIVE_ARMOR_AXL] = new Type[] {typeof(CH125_Controller)},
        [EControlCharacter_.SIGMA_TAICHO] = new Type[] {typeof(CH126_Controller)},
        [EControlCharacter_.ERATOEIR_DOKUZON] = new Type[] {typeof(CH127_Controller)},
        [EControlCharacter_.X_SHADOW_ARMOR] = new Type[] {typeof(CH131_Controller)},
        [EControlCharacter_.MHRSB_X] = new Type[] {typeof(CH129_Controller)},
        [EControlCharacter_.MHRSB_iCO] = new Type[] {typeof(CH130_Controller)},
        [EControlCharacter_.DIVE_ARMOR_ROCKMAN_EXE] = new Type[] {typeof(CH128_Controller)},
        [EControlCharacter_.ZERO_HALLOWEEN] = new Type[] {typeof(CH133_Controller)},
        [EControlCharacter_.ViA_HALLOWEEN] = new Type[] {typeof(CH132_Controller)},
        [EControlCharacter_.FORTE_AND_GOSPEL] = new Type[] {typeof(CH134_Controller)},
        [EControlCharacter_.iCO_XMAS] = new Type[] {typeof(CH135_Controller)},
        [EControlCharacter_.X_S] = new Type[] {typeof(CH143_Controller)},
        [EControlCharacter_.Z_S] = new Type[] {typeof(CH144_Controller)},
        [EControlCharacter_.RiCO_DIVE_ARMOR] = new Type[] {typeof(CH136_Controller)},
        [EControlCharacter_.IRIS_DIVE_ARMOR] = new Type[] {typeof(CH137_Controller)},
        [EControlCharacter_.VIA_QED] = new Type[] {typeof(CH138_Controller)},
        [EControlCharacter_.iCO_DIVE_ARMOR] = new Type[] {typeof(CH139_Controller)},
        [EControlCharacter_.X_DMC] = new Type[] {typeof(CH140_Controller)},
        [EControlCharacter_.Z_DMC] = new Type[] {typeof(CH141_Controller)},
        [EControlCharacter_.X__DIVE_ARMOR_SP] = new Type[] {typeof(CH142_Controller)},
        [EControlCharacter_.NPC_Y] = new Type[] {typeof(ZeroController)},
        [EControlCharacter_.NPC_Y_BROKEN] = new Type[] {typeof(ZeroController)},
        [EControlCharacter_.NPC_X_REUS_ARMOR] = new Type[] {typeof(CH093_Controller)}
    };

    [HarmonyPrefix]
    [HarmonyPatch(nameof(CharacterControlFactory.GetCharacterControlType))]
    public static bool GetCharacterControlType(EControlCharacter character, int subID, ref Il2CppSystem.Type __result) {
        Type[] t = _dictCtrl[(EControlCharacter_)character];

        if (t == null) {
            Plugin.Log.LogWarning($"未定義的Player類型: {character}");
            __result = Il2CppType.From(typeof(ZeroController));
            return false;
        }

        __result = Il2CppType.From(t.Length > subID ? t[subID] : t[0]);
        return false;
    }
}