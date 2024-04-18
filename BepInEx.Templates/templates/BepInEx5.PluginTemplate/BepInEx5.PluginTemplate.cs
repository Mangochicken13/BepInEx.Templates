using BepInEx;
using BepInEx.Logging;

namespace BepInEx5.PluginTemplate;

[BepInPlugin(MyPluginInfo.PLUGIN_GUID, MyPluginInfo.PLUGIN_NAME, MyPluginInfo.PLUGIN_VERSION)]
public class BepInEx5.PluginTemplate : BaseUnityPlugin
{
    internal static ManualLogSource Log;
        
    private void Awake()
    {
        Log = Logger;

        // Plugin startup logic
        
        Log.LogInfo($"Plugin {MyPluginInfo.PLUGIN_GUID} is loaded!");
    }
}
