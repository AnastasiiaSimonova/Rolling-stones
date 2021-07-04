using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrystalMovement : MonoBehaviour
{
    private DetectCollision DCScript;
    public MainManager MMScript;

    private float speed = 20;
    private float zPos = -15;

    // Start is called before the first frame update
    void Start()
    {
        DCScript = GameObject.Find("Player").GetComponent<DetectCollision>();
        MMScript = GameObject.Find("MainManager").GetComponent<MainManager>();
    }

    // Update is called once per frame
    void Update()
    {
        MoveCrystals();
    }
     
    // moves crystals;
    void MoveCrystals()
    {
        if (!DCScript.gameOver)
        {
            transform.Translate(Vector3.back * speed * Time.deltaTime);
            if (transform.position.z < zPos || DCScript.gameOver)
            {
                Destroy(gameObject);
            }
        }
    }

    // destroys crystals after ball has touched it;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {
            MMScript.UpdateScore();
            Destroy(gameObject);            
        }
    }

}
