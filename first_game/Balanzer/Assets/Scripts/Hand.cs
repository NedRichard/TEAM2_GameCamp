using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hand : MonoBehaviour
{

    public float speed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move(){
        //Vector3 newPosition = transform.position;

        float direction = Input.GetAxis("Mouse X");

        transform.position += new Vector3(direction, 0, 0) * speed * Time.deltaTime;

        if(Input.GetAxis("Mouse X")<0) {
            Debug.Log("Moving Left");
        } else if(Input.GetAxis("Mouse X")>0) {
            Debug.Log("Moving Right");
        }

    }
}
