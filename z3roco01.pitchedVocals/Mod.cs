using GDWeave;

namespace z3roco01.pitchedVocals;

public class Mod : IMod {
    public static Config config;
    public static IModInterface ModInterface;

    public Mod(IModInterface modInterface) {
        ModInterface = modInterface;
        config = modInterface.ReadConfig<Config>();

        // clamp the config between max and mins, and save it 
        config.pitchFactor = Math.Clamp(config.pitchFactor, 0.0f, 5.0f);
        modInterface.WriteConfig(config);

        modInterface.RegisterScriptMod(new BarkMod());
        modInterface.Logger.Information("pitch vocals loaded !");
    }

    public void Dispose() {
    }
}
