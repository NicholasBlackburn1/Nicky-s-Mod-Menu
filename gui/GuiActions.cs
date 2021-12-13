using MelonLoader;
using NickysModMenu.utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;
using VRC.Core;
using VRC.UI;

namespace NickysModMenu.gui
{
    static class GuiActions
    {


        // This allows me to dump public and private avi's to the console
        public static Action CloneAvatar(string downloadlocal)
        {
            return new Action(() =>
            {
                Transform screens = GameObject.Find("UserInterface").transform.Find("MenuContent/Screens/").transform;
                PageWorldInfo pageWorldInfo = screens.Find("WorldInfo").GetComponent<PageWorldInfo>();
                MenuController menuController = pageWorldInfo.field_Public_MenuController_0;
                PageAvatar avatarPage = screens.Find("Avatar").GetComponent<PageAvatar>();

                // avatar info

                string avatarID = menuController.activeAvatarId;
                string avatarURL = menuController.activeAvatar.assetUrl;
                string avatarName = menuController.activeAvatar.name;
                string avatarVersion = menuController.activeAvatar.assetVersion.ToString();



                if (menuController.activeAvatar.releaseStatus == "private")
                {
                    avatarPage.field_Public_SimpleAvatarPedestal_0.field_Internal_ApiAvatar_0 = new ApiAvatar { id = avatarID };
                    ActionHelpers.DisplayAvatarInfoInConsole(avatarID, avatarName, avatarURL, avatarVersion, "Private");

                    // Warning message for cloning a private avatar
                    VRCUiPopupManager.prop_VRCUiPopupManager_0.Method_Public_Void_String_String_String_Action_Action_1_VRCUiPopup_2("Private Avatar!", "You really can't clone a Private avatar vrchat is not made that way. Download it insted", "OwO Do it ", new Action(() =>
                    {
                        Nickyslogger.info("Downloading Private  Avi...");
                        ActionHelpers.Downloader(avatarURL, avatarName, downloadlocal);

                    }), null);

                }
                else
                {

                    avatarPage.field_Public_SimpleAvatarPedestal_0.field_Internal_ApiAvatar_0 = new ApiAvatar { id = avatarID };
                    ActionHelpers.DisplayAvatarInfoInConsole(avatarID, avatarName, avatarURL, avatarVersion, "Public");

                    // Warning message for cloning a private avatar
                    VRCUiPopupManager.prop_VRCUiPopupManager_0.Method_Public_Void_String_String_String_Action_Action_1_VRCUiPopup_2("Public Avatar!", "Cloning a Public avatar is amazing, but be carefull you could get fucked by vrc admins!", "OwO Do it ", new Action(() =>
                    {
                        MelonLogger.Msg("Cloneing Avi...");
                        avatarPage.ChangeToSelectedAvatar();

                    }), null);

                }

            });


        }

        public static Action AvatarInfo(string downloadlocal)
        {
            return new Action(() =>
            {
                Transform screens = GameObject.Find("UserInterface").transform.Find("MenuContent/Screens/").transform;
                PageWorldInfo pageWorldInfo = screens.Find("WorldInfo").GetComponent<PageWorldInfo>();
                MenuController menuController = pageWorldInfo.field_Public_MenuController_0;
                PageAvatar avatarPage = screens.Find("Avatar").GetComponent<PageAvatar>();

                // avatar info

                string avatarID = menuController.activeAvatarId;
                string avatarURL = menuController.activeAvatar.assetUrl;
                string avatarName = menuController.activeAvatar.name;
                string avatarVersion = menuController.activeAvatar.assetVersion.ToString();



                if (menuController.activeAvatar.releaseStatus == "private")
                {
                    avatarPage.field_Public_SimpleAvatarPedestal_0.field_Internal_ApiAvatar_0 = new ApiAvatar { id = avatarID };
                    ActionHelpers.DisplayAvatarInfoInConsole(avatarID, avatarName, avatarURL, avatarVersion, "Private");

                    // Shows avatar info in a nice popup
                    ActionHelpers.AvatarInfoPopUp(ActionHelpers.avatarInfoString(avatarID, avatarName, avatarURL, "Private"), avatarURL, avatarName, downloadlocal);

                }
                else
                {

                    avatarPage.field_Public_SimpleAvatarPedestal_0.field_Internal_ApiAvatar_0 = new ApiAvatar { id = avatarID };

                    ActionHelpers.DisplayAvatarInfoInConsole(avatarID, avatarName, avatarURL, avatarVersion, "Public");
                    // Shows avatar info in a nice popup
                    ActionHelpers.AvatarInfoPopUp(ActionHelpers.avatarInfoString(avatarID, avatarName, avatarURL, "Public"), avatarURL, avatarName, downloadlocal);

                }

            });



        }


        public static Action changFileLocal()
        {
            return new Action(() =>
            {
                MelonLogger.Msg("Need to set up the file download path time to to use gui to set it up~");

                // tbis 
                ActionHelpers.ShowInputPopupWithCancel(VRCUiPopupManager.prop_VRCUiPopupManager_0, "Avatar Download Location", "Enter a windows path dir to dump avatar files to", InputField.InputType.Standard, false, "Submit", (s, k, t) =>
                {

                    if (string.IsNullOrEmpty(s))
                        return;

                    try
                    {
                        MelonLogger.Msg("PAth is for download local" + " " + Path.GetFullPath(@s));

                        if (Path.GetFullPath(@s) != null)
                        {
                            Main.downloadpath.Value = @s;
                        }
                        else
                        {
                            MelonLogger.Warning("File path is not valid please fix the path");
                        }
                    }

                    catch (Exception e)
                    {
                        MelonLogger.Warning(e.Message);
                    }


                }, new Action(() => { }));
            });
        }


        // this should launch my new menu 
        public static Action openModInfoMenu()
        {
            return new Action(() =>
            {
                MelonLogger.Msg("-------MOD INFORMATION---------");
                MelonLogger.Msg(" Version" + " " + "1.0.0");

                VRCUiPopupManager.prop_VRCUiPopupManager_0.Method_Public_Void_String_String_Single_1("Mod Info", ActionHelpers.modInfo());

            });
        }


      


    }
}
