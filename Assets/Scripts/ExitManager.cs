using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitManager : MonoBehaviour
{
    public GameObject ExitPanel;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Time.timeScale = 0;
            ExitPanel.SetActive(true);
        }
    }


    public void ExitYesBtnClick()
    {
        Application.Quit();
    }

    public void ExitNoBtnClick()
    {
        Time.timeScale = 1;

        ExitPanel.SetActive(false);
    }
}
