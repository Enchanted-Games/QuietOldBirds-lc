using HarmonyLib;

namespace QuietOldBirds.Patches;

[HarmonyPatch(typeof(RadMechAI))]
public class RadMechAIPatch
{
    [HarmonyPatch(nameof(RadMechAI.Start))]
    [HarmonyPostfix]
    static void Postfix(RadMechAI __instance)
    {
        __instance.creatureSFX.volume = 0.1f;
        __instance.creatureVoice.volume = 0.1f;
        __instance.LocalLRADAudio.volume = 0.1f;
        __instance.LocalLRADAudio2.volume = 0.1f;
        __instance.engineSFX.volume = 0.2f;
        __instance.explosionAudio.volume = 0.1f;
    }
}
