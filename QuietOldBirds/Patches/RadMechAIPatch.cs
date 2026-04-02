using HarmonyLib;
using QuietOldBirds.Config;

namespace QuietOldBirds.Patches;

[HarmonyPatch(typeof(RadMechAI))]
public class RadMechAIPatch
{
    [HarmonyPatch(nameof(RadMechAI.Start))]
    [HarmonyPostfix]
    static void Postfix(RadMechAI __instance)
    {
        __instance.creatureSFX.volume = ConfigManager.CreatureSFX.Value;
        __instance.LocalLRADAudio.volume = ConfigManager.LocalRad.Value;
        __instance.LocalLRADAudio2.volume = ConfigManager.LocalRad.Value;
        __instance.engineSFX.volume = ConfigManager.EngineSFX.Value;
        __instance.explosionAudio.volume = ConfigManager.Explosion.Value;
    }
}
