using EFT.Interactive;
using System.Reflection;
using Aki.Reflection.Patching;

namespace NoMoreMines
{
    public class MinesPatch : ModulePatch
    {
        protected override MethodBase GetTargetMethod()
        {
            var result = typeof(Minefield).GetMethod("IsInTriggerZone", BindingFlags.Instance | BindingFlags.NonPublic);
            return result;
        }

        [PatchPostfix]
        static void PostFix(ref bool __result)
        {
            __result = false;
        }
    }
}