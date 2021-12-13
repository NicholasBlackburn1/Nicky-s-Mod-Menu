using MelonLoader;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;
using VRC.Core;
using VRC.UI;


namespace NickysModMenu.gui { 

    class LeftWingMenu
{


    public IEnumerator OnMainTitleRun(string message)
    {
        // whenever the usermanage face is avctive 
        while (GameObject.Find("UserInterface").GetComponentInChildren<VRC.UI.Elements.QuickMenu>(true) == null) yield return null;

        Transform Main_Menu_title = GameObject.Find("UserInterface").transform.Find(Consts.MainMenuTitlePath);
        Main_Menu_title.GetComponent<TMPro.TextMeshProUGUI>().text = message;
    }

    public IEnumerator onSafty()
    {
        // whenever the usermanage face is avctive 
        while (GameObject.Find("UserInterface").GetComponentInChildren<VRC.UI.Elements.QuickMenu>(true) == null) yield return null;

        Transform saftey = GameObject.Find("UserInterface").transform.Find(Consts.toggleSaftyPath);

        saftey.GetComponent<Button>().onClick = new Button.ButtonClickedEvent();
        //saftey.GetComponent<Button>().onClick.AddListener(GuiActions.DumpAvatarInfo());
    }




    public IEnumerator OnLeftWingTitle(string message)
    {
        // whenever the usermanage face is avctive 
        while (GameObject.Find("UserInterface").GetComponentInChildren<VRC.UI.Elements.QuickMenu>(true) == null) yield return null;

        Transform Main_Menu_title = GameObject.Find("UserInterface").transform.Find(Consts.Leftwingtitlepath);
        Main_Menu_title.GetComponent<TMPro.TextMeshProUGUI>().text = Consts.ModTitle;
    }



    public IEnumerator OnFirstButtonTitle()
    {
        // whenever the usermanage face is avctive 
        while (GameObject.Find("UserInterface").GetComponentInChildren<VRC.UI.Elements.QuickMenu>(true) == null) yield return null;

        Transform Main_Menu_title = GameObject.Find("UserInterface").transform.Find(Consts.LeftwingFirstButtonTitle);
        Main_Menu_title.GetComponent<TMPro.TextMeshProUGUI>().text = Consts.ModFirstButton;
    }

    public IEnumerator OnSecondButtonTitle()
    {
        // whenever the usermanage face is avctive 
        while (GameObject.Find("UserInterface").GetComponentInChildren<VRC.UI.Elements.QuickMenu>(true) == null) yield return null;

        Transform Main_Menu_title = GameObject.Find("UserInterface").transform.Find(Consts.LeftwingSecondButtonTitle);
        Main_Menu_title.GetComponent<TMPro.TextMeshProUGUI>().text = Consts.AviInfo;
    }

    public IEnumerator OnThirdButtonTitle()
    {
        // whenever the usermanage face is avctive 
        while (GameObject.Find("UserInterface").GetComponentInChildren<VRC.UI.Elements.QuickMenu>(true) == null) yield return null;
        GameObject pub = GameObject.Find("UserInterface");

        Transform Main_Menu_title = GameObject.Find("UserInterface").transform.Find(Consts.LeftwingThirdButton);
        Main_Menu_title.GetComponent<TMPro.TextMeshProUGUI>().text = Consts.Graphing;

    }



        public IEnumerator OnFourthButtonTitle()
        {
            // whenever the usermanage face is avctive 
            while (GameObject.Find("UserInterface").GetComponentInChildren<VRC.UI.Elements.QuickMenu>(true) == null) yield return null;
            GameObject pub = GameObject.Find("UserInterface");

            Transform Main_Menu_title = GameObject.Find("UserInterface").transform.Find(Consts.LeftwingFourthButton);
            Main_Menu_title.GetComponent<TMPro.TextMeshProUGUI>().text = Consts.Path;
        }



    //TODO: get a window to dislay mod infox
    public IEnumerator OnModInfoButtonPress()
    {
        // whenever the usermanage face is avctive 
        while (GameObject.Find("UserInterface").GetComponentInChildren<VRC.UI.Elements.QuickMenu>(true) == null) yield return null;
        Transform modinfoButton = GameObject.Find("UserInterface").transform.Find(Consts.GUIModButton);

        modinfoButton.GetComponent<Button>().onClick = new Button.ButtonClickedEvent();
        modinfoButton.GetComponent<Button>().onClick.AddListener(GuiActions.openModInfoMenu());
    }


    // this will dump avatar info and should display it 
    // TODO: get data to be displayed from avatar
    public IEnumerator OnAvatarCloneButtonPress(string download)
    {
        // whenever the usermanage face is avctive 
        while (GameObject.Find("UserInterface").GetComponentInChildren<VRC.UI.Elements.QuickMenu>(true) == null) yield return null;
        Transform modinfoButton = GameObject.Find("UserInterface").transform.Find(Consts.GUIClone);

        modinfoButton.GetComponent<Button>().onClick = new Button.ButtonClickedEvent();
        modinfoButton.GetComponent<Button>().onClick.AddListener(GuiActions.CloneAvatar(download));



    }


    public IEnumerator OnAvatarInfoButtonPress(string download)
    {
        // whenever the usermanage face is avctive 
        while (GameObject.Find("UserInterface").GetComponentInChildren<VRC.UI.Elements.QuickMenu>(true) == null) yield return null;
        Transform modinfoButton = GameObject.Find("UserInterface").transform.Find(Consts.GUIAvatarButton);

        modinfoButton.GetComponent<Button>().onClick = new Button.ButtonClickedEvent();
        modinfoButton.GetComponent<Button>().onClick.AddListener(GuiActions.AvatarInfo(download));



    }



    public IEnumerator OnSetAvatarPathButtonPress()
    {
        // whenever the usermanage face is avctive 
        while (GameObject.Find("UserInterface").GetComponentInChildren<VRC.UI.Elements.QuickMenu>(true) == null) yield return null;
        Transform modinfoButton = GameObject.Find("UserInterface").transform.Find(Consts.GUIPath);

        modinfoButton.GetComponent<Button>().onClick = new Button.ButtonClickedEvent();
        modinfoButton.GetComponent<Button>().onClick.AddListener(GuiActions.changFileLocal());



    }



}
}
