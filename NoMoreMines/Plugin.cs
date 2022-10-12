using BepInEx;

namespace NoMoreMines
{
    [BepInPlugin("com.kobrakon.nomoremines","NoMoreMines", "1.0.0")]
    public class Plugin : BaseUnityPlugin
    {
        void Awake()
        {
            new MinesPatch().Enable();
        }
    }
}
