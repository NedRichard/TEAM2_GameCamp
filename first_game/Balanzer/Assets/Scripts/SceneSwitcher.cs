using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    
    public static void SwitchToMain() {
        SceneManager.LoadScene("MainMenu");
    }

    public static void SwitchToGame() {
        SceneManager.LoadScene("GameView");
    }

    public static void SwitchToGameOver() {
        //SceneManager.LoadScene("GameOver");
    }
}
