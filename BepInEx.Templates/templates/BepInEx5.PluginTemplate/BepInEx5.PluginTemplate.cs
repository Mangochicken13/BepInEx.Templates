using BepInEx;
using BepInEx.Logging;

namespace BepInEx5.PluginTemplate;

[BepInPlugin(ModID, ModName, ModVersion)]
public class BepInEx5.PluginTemplate : BaseUnityPlugin
{
    public const string ModID = "com.mangochicken.BepInEx5.PluginTemplate";
    public const string ModName = "BepInEx5.PluginTemplate";
    public const string ModVersion = "{version}";

    internal static ManualLogSource Log;

    public BepInEx5.PluginTemplate Instance { get; private set; }
        
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            DestroyImmediate(gameObject);
            return;
        }

        Log = Logger;

        // Plugin startup logic

        Log.LogInfo($"Plugin {ModID} is loaded!");
    }
}
