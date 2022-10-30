using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StgPopup : MonoBehaviour
{
    public Canvas canvas;
    public bool a = false;
    public void PopUp()
    {
        if (a == false)
        {
            canvas.enabled = true;
            a = true;
        }
        else if (a == true)
        {
            canvas.enabled = false;
            a = false;
        }
    }
}
