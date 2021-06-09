using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static bool started = false;

    bool spawnCube = false;

    public int piecesSpawned = 0;

    public float spawnClock = 0f;

    public GameObject cube = null;
    public GameObject currentCube = null;

    void FixedUpdate()
    {
        spawnClock += Time.fixedDeltaTime;
        Debug.Log("Waiting for spawn");

        if(spawnClock>=6f) {
            piecesSpawned += 1;
            
            spawnCube = true;
            
                if(piecesSpawned<=5 && spawnCube) {
                    spawnClock = 0f;
                    SpawnPiece();
                    Debug.Log("Spawned a cube!");
                    Debug.Log("Pieces spawned: " + piecesSpawned);
                    spawnCube = false;
                }

        }

    }

    void SpawnPiece() {
        currentCube = Instantiate(cube);
    }

}
