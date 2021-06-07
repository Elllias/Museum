using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogScript : MonoBehaviour
{
    public bool EndDialog;
    public GameObject Dialog1;
    public Animator startAnim;
    private bool inp = false;
    private bool isEnter = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        inp = false;

        if (Input.GetKeyDown(KeyCode.F))
        {
            inp = true;
        }

        if (inp == true && isEnter == true)
        {
            Time.timeScale = 0;
            Dialog1.SetActive(true);
        }

        if (EndDialog == true)
        {
            Time.timeScale = 1;
            inp = false;
            EndDialog = false;
            Dialog1.SetActive(false);
        }
    }

    void OnTriggerEnter(Collider col)
    {
        startAnim.SetBool("startDialog", true);
        if (col.tag == "Player")
        {
            isEnter = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        startAnim.SetBool("startDialog", false);
        inp = false;
        isEnter = false;
        EndDialog = false;
    }
}
