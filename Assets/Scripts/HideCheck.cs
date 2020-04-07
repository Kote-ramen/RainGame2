using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideCheck : MonoBehaviour
{
    private string hideTag = "Hide";
    private bool isHide = false;
    private bool isHideEnter, isHideStay, isHideExit;

    public bool IsHide()
    {
        if (isHideStay)
        {
            isHide = true;
        }
        else if (isHideEnter || isHideExit)
        {
            isHide = false;
        }

        isHideEnter = false;
        isHideStay = false;
        isHideExit = false;
        return isHide;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == hideTag)
        {
            isHideEnter = true;
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == hideTag)
        {
            isHideStay = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == hideTag)
        {
            isHideExit = true;
        }
    }
}
