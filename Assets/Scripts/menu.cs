using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class menu : MonoBehaviour
{
    public GameObject loadingScreen, menuObj, settingsObj;
    public string sceneName, sceneName2;
    public Button continueButton;

    private void Start()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }
    public void playGame()
    {
        loadingScreen.SetActive(true);
        PlayerPrefs.SetInt("level", 1);
        PlayerPrefs.Save();
        SceneManager.LoadScene(sceneName);
    }

    public void ContinueGame()
    {
        loadingScreen.SetActive(true);
        if (PlayerPrefs.GetInt("level", 2) == 2)
        {
            SceneManager.LoadScene(sceneName2);
        }
        if (PlayerPrefs.GetInt("level", 1) == 1)
        {
            SceneManager.LoadScene(sceneName);
        }
        if (PlayerPrefs.GetInt("level", 0) == 0)
        {
            SceneManager.LoadScene(sceneName);
        }
    }

    public void settings()
    {
        menuObj.SetActive(false);
        settingsObj.SetActive(true);
    }

    public void QuitGame()
    {
        Debug.Log("Game quit");
        Application.Quit();
    }

    public void backToMenu()
    {
        settingsObj.SetActive(false);
        menuObj.SetActive(true);
    }
}
