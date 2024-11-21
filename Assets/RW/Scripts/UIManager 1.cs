using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager1 : MonoBehaviour
{
    public Animator startButton;
    public Animator settingsButton;

    public Animator dialog;
    public void StartGame()
    {
        SceneManager.LoadScene("RocketMouse");
    }
    
    public void OpenSettings()
    {
        startButton.SetBool("isHidden",  true);
        settingsButton.SetBool("isHidden", false);
    }
}
