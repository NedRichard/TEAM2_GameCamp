using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeContacts : MonoBehaviour
{

    void OnTriggerEnter() {
        Debug.Log("Game Over!");
        GameManager.gameOver = true;
        //SceneSwitcher.SwitchToGameOver();
    }
}
