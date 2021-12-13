﻿using MelonLoader;
using NickysModMenu.gui;
using System;
using VRC;
using VRC.Core;


namespace NickysModMenu
{
    public static class BuildInfo
    {
        public const string Name = "Nicky's Mod Menu"; // Name of the Mod.  (MUST BE SET)
        public const string Description = "A Vrchat Mod Menu That will Add cool stuff into vrc"; // Description for the Mod.  (Set as null if none)
        public const string Author = "Nicky Blackburn"; // Author of the Mod.  (MUST BE SET)
        public const string Company = null; // Company that made the Mod.  (Set as null if none)
        public const string Version = "1.0.0"; // Version of the Mod.  (MUST BE SET)
        public const string DownloadLink = null; // Download Link for the Mod.  (Set as null if none)
    }

    public class Main : MelonMod
    {
        private RegisterGui registerGui = new RegisterGui();
        public static MelonPreferences_Category settingsCategory;
        public static MelonPreferences_Entry<string> downloadpath;

        public override void OnApplicationStart() // Runs after Game Initialization.
        {
            InitMod();   
        }

        public override void OnApplicationLateStart() // Runs after OnApplicationStart.
        {
           
        }

        public override void OnSceneWasLoaded(int buildindex, string sceneName) // Runs when a Scene has Loaded and is passed the Scene's Build Index and Name.
        {
            try
            {
                registerGui.registerGuiLayout();
            }
            catch(Exception e)
            {
                MelonLogger.Msg(ConsoleColor.DarkRed, e.Message);

            }
            
        }

        public override void OnSceneWasInitialized(int buildindex, string sceneName) // Runs when a Scene has Initialized and is passed the Scene's Build Index and Name.
        {
            MelonLogger.Msg("OnSceneWasInitialized: " + buildindex.ToString() + " | " + sceneName);
        }

        public override void OnUpdate() // Runs once per frame.
        {
            MelonLogger.Msg("OnUpdate");
        }

        public override void OnFixedUpdate() // Can run multiple times per frame. Mostly used for Physics.
        {
            MelonLogger.Msg("OnFixedUpdate");
        }

        public override void OnLateUpdate() // Runs once per frame after OnUpdate and OnFixedUpdate have finished.
        {
            MelonLogger.Msg("OnLateUpdate");
        }

        public override void OnGUI() // Can run multiple times per frame. Mostly used for Unity's IMGUI.
        {
            MelonLogger.Msg("OnGUI");
        }

        public override void OnApplicationQuit() // Runs when the Game is told to Close.
        {
            MelonLogger.Msg("OnApplicationQuit");
        }

        public override void OnPreferencesSaved() // Runs when Melon Preferences get saved.
        {
            MelonLogger.Msg("OnPreferencesSaved");
        }

        public override void OnPreferencesLoaded() // Runs when Melon Preferences get loaded.
        {
            MelonLogger.Msg("OnPreferencesLoaded");
        }

        public override void BONEWORKS_OnLoadingScreen() // Runs when BONEWORKS shows the Loading Screen. Only runs if the Melon is used in BONEWORKS.
        {
            MelonLogger.Msg("BONEWORKS_OnLoadingScreen");
        }


        // allows me to add setup stuff to main startup function
        public void InitMod()
        {
            settingsCategory = MelonPreferences.CreateCategory(Consts.SettingConfig);
            downloadpath = (MelonPreferences_Entry<string>)settingsCategory.CreateEntry("downloadpath", "EnterPath");
        }


    }
}