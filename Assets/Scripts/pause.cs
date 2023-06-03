using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class pause : MonoBehaviour
{
    public GameObject pausemenu, settingsmenu;
    public string sceneName;
    public bool toggle;
    public SC_FPSController playerScript;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            toggle = !toggle;
            if (toggle == false)
            {
                AudioListener.pause = false;
                pausemenu.SetActive(false);
                Time.timeScale = 1;
                playerScript.enabled = true;
                Cursor.visible = false;
                Cursor.lockState = CursorLockMode.Locked;
            }
            if (toggle == true)
            {
                AudioListener.pause = true;
                pausemenu.SetActive(true);
                Time.timeScale = 0;
                playerScript.enabled = false;
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
            }
        }
    }

    public void toSettings()
    {
        pausemenu.SetActive(false);
        settingsmenu.SetActive(true);
    }

    public void toPauseMenu()
    { 
        settingsmenu.SetActive(false);
        pausemenu.SetActive(true);
    }
    public void ResumeGame()
    {
        AudioListener.pause = false;
        toggle = false;
        pausemenu.SetActive(false);
        Time.timeScale = 1;
        playerScript.enabled = true;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
    public void QuitToMenu()
    {
        AudioListener.pause = false;
        Time.timeScale = 1;
        SceneManager.LoadScene(sceneName);
    }
}
