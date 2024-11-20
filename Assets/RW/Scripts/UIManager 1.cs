using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager1 : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("RocketMouse");
    }
}
