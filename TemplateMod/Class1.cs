using HarmonyLib;
using NeosModLoader;
using System;
using FrooxEngine;
namespace $safeprojectname$
{
    public class $safeprojectname$ : NeosMod
    {
        public override string Name => "$safeprojectname$";
        public override string Author => "$modauthor$";
        public override string Version => "1.0.0";
        public override string Link => "https://github.com/$modauthor$/$safeprojectname$";
        public override void OnEngineInit()
        {
            Harmony harmony = new Harmony("me.$modauthor$.$safeprojectname$");
            harmony.PatchAll();
        }

        [HarmonyPatch(typeof($targettype$), "$targetmethod$")]
        class $targettype$_$targetmethod$_Patch
        {
            public static void Prefix($targettype$ __instance)
            {
            }
            public static void Postfix($targettype$ __instance)
            {
            }
        }
    }
}