using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleScreenManager : MonoBehaviour {

    public string StartButton = "";
    public string CreditsButton = "";

    public void OnStartButtonClick()
    {
        SceneManager.LoadScene(StartButton);
    }

    public void OnCreditsButtonClick()
    {
        SceneManager.LoadScene(CreditsButton);
    }

    public void OnQuitButtonClick()
    {
        Application.Quit();
    }
}
