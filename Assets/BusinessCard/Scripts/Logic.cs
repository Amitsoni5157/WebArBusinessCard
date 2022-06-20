using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Logic : MonoBehaviour
{
    public void ClickOnCall()
    {
        Application.OpenURL("tel:+85223529283");
    }

    public void ClickOnUrl()
    {
        Application.OpenURL("https://www.tvhk.com.hk/contact/");
    }
}
