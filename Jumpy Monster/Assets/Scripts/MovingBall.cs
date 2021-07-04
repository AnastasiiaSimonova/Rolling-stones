using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingBall : MonoBehaviour
{

    private float speed = 21f;
    private float maxZrange = 50f;   
    // Update is called once per frame
    void Update()
    {
        MoveBallForward();
         
        // destroys out of bounds;
        if (transform.position.z > maxZrange)
        {
            Destroy(gameObject);
        }
    }

    // moves forward;
    void MoveBallForward()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

}
