using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    private float speed = 100;
    private Rigidbody stoneRB;
    private Vector3 torqueVector = new Vector3(-360, 0, 0);
    private float zMax = -25;
       

    // Start is called before the first frame update
    void Start()
    {
        stoneRB = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // transform.Translate(Vector3.forward * Time.deltaTime * speed);
        // transform.Rotate(rotationVector * Time.deltaTime, Space.Self);
        stoneRB.AddForce(Vector3.back*speed);
        stoneRB.AddTorque(torqueVector*Time.deltaTime, ForceMode.Impulse);
        
        // destroys out of bounds;
        if (transform.position.z < zMax)
        {
            Destroy(gameObject);
        }

    }
}



    