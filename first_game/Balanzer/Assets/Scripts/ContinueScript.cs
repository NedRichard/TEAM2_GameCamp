using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContinueScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.anyKey) {
            Debug.Log("Moved to main menu!");
            SceneSwitcher.SwitchToMain();
        }

    }
}
