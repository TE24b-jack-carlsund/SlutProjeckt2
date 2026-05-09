using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitSceneChanger : MonoBehaviour
{
    //Kopierad, denna fungerar bara ifall du skulle ladda upp projecktet från vad jag har hört(fungerar inte i scenen)
    public void ExitGame()
    {
        //går ur spelet/applikationen
        Application.Quit();
    }
}