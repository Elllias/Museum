using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuOnTab : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            //This is used to be sure to unlock the UI cursor when leaving the scene
            Cursor.lockState = CursorLockMode.None;

            //This loads scene 0. The intro scene is really small, that's why we use another method.
            SceneManager.LoadScene(0);
        }
    }
}