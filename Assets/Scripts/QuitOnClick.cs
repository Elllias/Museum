using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitOnClick : MonoBehaviour
{

    public void OnApplicationQuit()
    {
        //we want an other behavior depending the runtime environment
        //https://docs.unity3d.com/Manual/PlatformDependentCompilation.html
#if UNITY_EDITOR
UnityEditor.EditorApplication.isPlaying = false;
#elif UNITY_WEBGL
if(Screen.fullScreen == true)
{
Screen.fullScreen = !Screen.fullScreen;
}
Application.OpenURL("http://mountainpath.ch/cmsimplexh/index.php?Unity-3D/Create-a-virtual-museum-in-one-day");
#else
        Application.Quit();
#endif
    }
}