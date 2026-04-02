using BepInEx.Configuration;

namespace QuietOldBirds.Config;

public static class ConfigManager
{
    public static ConfigEntry<float> CreatureSFX;
    public static ConfigEntry<float> LocalRad;
    public static ConfigEntry<float> EngineSFX;
    public static ConfigEntry<float> Explosion;
    
    public static void RegisterConfig(ConfigFile config)
    {
        CreatureSFX = config.Bind(
            "Old Bird Volume",
            "Creature SFX",
            0.1f,
            "Footstep stomp sounds"
        );
        
        LocalRad = config.Bind(
            "Old Bird Volume",
            "Local Rad",
            0.1f,
            "Screaming / crying sounds"
        );
        
        EngineSFX = config.Bind(
            "Old Bird Volume",
            "Engine SFX",
            0.1f,
            "Idle beeping and humming sounds"
        );
        
        Explosion = config.Bind(
            "Old Bird Volume",
            "Explosion",
            0.1f,
            "Explosion sound when a missile shot by an old bird hits something"
        );
    }
}