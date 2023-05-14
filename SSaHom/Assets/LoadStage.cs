using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadStage : MonoBehaviour
{
    public GameObject PopupSet;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape ))
        {
            PopupSet.SetActive(true);
        }
    }

    public void goStage()
    {
        SceneManager.LoadScene("Stage");
    }


}


