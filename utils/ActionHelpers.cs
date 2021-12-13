using System.Net;
using MelonLoader;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine.UI;
using UnityEngine;

namespace NickysModMenu.utils
{


    
    static class ActionHelpers
    {

        static WebClient client = new WebClient();

        static string aviname = null;
        static string aviPath = null;
        static DateTime time = new DateTime();
        public static DateTime Time { get => time; set => time = value; }


        public static void ShowInputPopupWithCancel(this VRCUiPopupManager popupManager, string title, string preFilledText,
           InputField.InputType inputType, bool useNumericKeypad, string submitButtonText,
           Action<string, Il2CppSystem.Collections.Generic.List<KeyCode>, Text> submitButtonAction,
           Action cancelButtonAction, string placeholderText = "Enter text....")
        {
            popupManager.Method_Public_Void_String_String_InputType_Boolean_String_Action_3_String_List_1_KeyCode_Text_Action_String_Boolean_Action_1_VRCUiPopup_Boolean_Int32_0(
                    title,
                    preFilledText,
                    inputType, useNumericKeypad, submitButtonText, submitButtonAction, cancelButtonAction, placeholderText, true, null);
        }




        // this allows me to create popups in one place without repeting the smae function
        public static void AvatarInfoPopUp(string avatarinfo, string avatarURL, string avatarName, string downloadlocal)
        {
            // Warning message for cloning a private avatar
            VRCUiPopupManager.prop_VRCUiPopupManager_0.Method_Public_Void_String_String_String_Action_Action_1_VRCUiPopup_2("Avatar Info!", avatarinfo, "Download Avatar ", new Action(() =>
            {
                MelonLogger.Msg("Downloading avatar..");
                Downloader(avatarURL, avatarName, downloadlocal);

            }), null);
        }

        // Displays info in a nice way for avatars
     
        public static void DisplayAvatarInfoInConsole(string avatarID, string avatarName, string avatarURL, string avatarVersion, string avatarStatus)
        {

            MelonLogger.Warning("------------GRABBED AVATAR DATA-----------");
            MelonLogger.Error("AVATAR STATUS:" + " " + avatarStatus);
            MelonLogger.Msg("AVATAR ID:" + " " + avatarID);
            MelonLogger.Msg("AVATAR NAME:" + " " + avatarName);
            MelonLogger.Msg("AVATAR ASSET URL:" + " " + avatarURL);
            MelonLogger.Msg("AVATAR Asset Version:" + " " + avatarVersion);
            MelonLogger.Msg("{" + "avatar_name:" + " " + " ' " + avatarName + " ' " + "," + "avatar_id:" + " " + " ' " + avatarID + " ' " + "," + "avatarurl:" + " " + " ' " + avatarURL + " ' " + "}");
            MelonLogger.Warning("------------Done GRABBING AVATAR DATA-----------");


        }
        // Downloads vrc avatars 
        public static void Downloader(string avatarurl, string avatarname, string path)
        {
            {

                string keyvalue = Main.downloadpath.Value;




                downloadavirn(path, avatarname, avatarurl, client);


            }
        }



        // downloads and saves vrc avatar
        public static void downloadavirn(string path, string avatarname, string avatarurl, WebClient client)
        {
            aviPath = path;
            aviname = avatarname.Replace(" ", String.Empty);


            MelonLogger.Warning("Starting Downloading File named" + " " + path + @"\" + avatarname + ".vrca");

            // sets and handles the vrca download with webclient 
            System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls | System.Net.SecurityProtocolType.Tls11 | System.Net.SecurityProtocolType.Tls12;
            DateTime startTime = DateTime.Now;
            time = startTime;

            client.Headers.Add("user-agent", "Mozilla/5.0 (Windows NT 6.1; Win64; x64; rv:47.0)");
            client.DownloadFileAsync(new Uri(avatarurl), path + @"\" + avatarname + ".vrca");

            // Specify a progress notification handler here ...
            client.DownloadFileCompleted += new AsyncCompletedEventHandler(DownloadFileCallback2);

        }



        public static void DownloadFileCallback2(object sender, AsyncCompletedEventArgs e)
        {


            if (e.Cancelled)
            {
                client.Dispose();
                MelonLogger.Msg("File download cancelled.");
            }

            if (e.Error != null)
            {
                client.Dispose();
                MelonLogger.Msg(e.Error.ToString());
            }
            else
            {
                try
                {
                    client.Dispose();

                    var elapsedTime = (DateTime.Now - time).TotalSeconds;

                    MelonLogger.Warning("It took about" + " " + elapsedTime + " " + " to download the avatar " + aviname + "\n");
                    MelonLogger.Msg("Done Downloading File named" + " " + aviPath + @"\" + aviname + ".vrca");

                    VRCUiPopupManager.prop_VRCUiPopupManager_0.Method_Public_Void_String_String_Single_0("Avatar Download Time", "It took about" + ",\n" + "Time Taken:" + elapsedTime + ",\n" + " To download " + "Avatar name: " + aviname + "\n" + "\n");


                }
                catch (Exception e3)
                {
                    MelonLogger.Msg(ConsoleColor.Red, e3.Message);
                }
            }
        }
        // Avatar uwu
        public static string avatarInfoString(string avatarID, string avatarName, string avatarURL, string status)
        {
            return "Avtar Name: " + avatarName + ",\n" + "Shared Status:" + " " + status + ",\n" + "Avatar ID :" + " " + avatarID + ",\n" + "Avatar URL:" + " " + avatarURL;
        }

        // mod info
        public static string modInfo()
        {
            return "ModName: " + BuildInfo.Name + "\n" + " Author: " + BuildInfo.Author + "\n" + "Version: " + BuildInfo.Version + "\n" + "Mod Url: " + BuildInfo.DownloadLink + " \n";
        }


    }

}
}
