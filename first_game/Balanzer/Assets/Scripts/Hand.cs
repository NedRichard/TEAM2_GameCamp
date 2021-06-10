using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hand : MonoBehaviour
{

    public float speed = 10f;
    public float tiltSpeed = 50f;

    public Vector3 clamp = Vector3.zero;

    // Update is called once per frame
    void Update()
    {
        Move();
        Tilt();
    }

    void Move(){
        
        float direction = Input.GetAxis("Mouse X");

        Vector3 newPosition = transform.position;

        newPosition += new Vector3(direction, 0, 0) * speed * Time.deltaTime;

        newPosition.x = Mathf.Clamp(newPosition.x, clamp.x, clamp.y);

        transform.position = newPosition;

        //transform.position += new Vector3(direction, 0, 0) * speed * Time.deltaTime;

        if(Input.GetAxis("Mouse X")<0) {
            //Debug.Log("Moving Left");
        } else if(Input.GetAxis("Mouse X")>0) {
            //Debug.Log("Moving Right");
        }

    }

    void Tilt() {

        float tiltDir = Input.GetAxis("Horizontal") * tiltSpeed * Time.deltaTime;

        Mathf.Clamp(tiltDir, -30f, 30f);

        transform.Rotate(0, tiltDir, 0, Space.Self);

    }
}
