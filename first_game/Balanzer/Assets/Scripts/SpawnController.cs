using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnController : MonoBehaviour
{

    public List<GameObject> prefabList = new List<GameObject>();

    private List<GameObject> piecesList = new List<GameObject>();

    bool spawnCube = false;

    public int piecesSpawned = 0;

    public float spawnClock = 0f;
    public float resetStageClock = 0f;

    public GameObject Cube;
    public GameObject LongCube;
    public GameObject Purplecube;
    public GameObject YellowCube;


    // Start is called before the first frame update
    void Start()
    {

        prefabList.Add(Cube);
        prefabList.Add(LongCube);
        prefabList.Add(Purplecube);
        prefabList.Add(YellowCube);

    }

    void FixedUpdate()
    {
        spawnClock += Time.fixedDeltaTime;
        Debug.Log("Waiting for spawn");

        if(spawnClock>=6f) {

            if(piecesSpawned<5) {
                spawnCube = true;
            } else {
                spawnCube = false;
            }
            
                if(piecesSpawned<5 && spawnCube) {
                    spawnClock = 0f;
                    SpawnPiece();
                    piecesSpawned += 1;
                    //Debug.Log("Spawned a cube!");
                    //Debug.Log("Pieces spawned: " + piecesSpawned);
                    spawnCube = false;
                }

        }

        //Add gameOver later
        if(piecesSpawned == 5) {
            resetStageClock += 1f;
            Debug.Log("Pieces spawned: " + piecesSpawned);
        }
            
        if(resetStageClock >= 300f && !GameManager.gameOver) {
            CleanStage();
        }

    }

    void SpawnPiece() {
        int sizeOfList = prefabList.Count;

        int index = Random.Range(0, sizeOfList);

        float spawnRange = Random.Range(-3f, 3f);

        //Quaternion rot = Quaternion.Euler(-90f, -90f, 0);

        //Instantiate(prefabList[index]);
        piecesList.Add(Instantiate(prefabList[index], new Vector3(spawnRange, 10, 5), prefabList[index].transform.rotation));

    }

    void CleanStage() {

        Debug.Log("Cleaning stage!");

        for(int i = piecesList.Count - 1 ; i >= 0; i--) {
            Destroy(piecesList[i]);
            piecesList.RemoveAt(i);
            Debug.Log("Size of the list: " + piecesList.Count);
        }

        spawnClock = 0.1f;
        piecesSpawned = 0;
        resetStageClock = 0f;
        
    }
}
