using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class StgPopup : MonoBehaviour
{
    public Canvas SettingMenu;
    public Canvas BuyMenu;
    public Canvas IndexMenu;
    bool a = false;
    bool b = false;
    bool c = false;
    public void PopUpSetting()
    {
        if (a == false)
        {
            SettingMenu.enabled = true;
            a = true;
        }
        else if (a == true)
        {
            SettingMenu.enabled = false;
            a = false;
        }
    }
    public void PopUpBuy()
    {
        if (b == false)
        {
            BuyMenu.enabled = true;
            b = true;
        }
        else if (b == true)
        {
            BuyMenu.enabled = false;
            b = false;
        }
    }
    public void PopUpIndex()
    {
        if (c == false)
        {
            IndexMenu.enabled = true;
            c = true;
        }
        else if (c == true)
        {
            IndexMenu.enabled = false;
            c = false;
        }
    }
}
