using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRB;
    private Collider playerCol;
    private DetectCollision DCScript;

    private float forceAdded = 300f;
    private bool isOnGround = true;
    private float gravityModifier = 2f;
    public GameObject ball;
    private Vector3 ballPos;
    private Vector3 ballLocationToAdd = new Vector3(0, 1, 3);

    // Start is called before the first frame update
    void Start()
    {
        playerCol = GetComponent<Collider>();
        playerRB = GetComponent<Rigidbody>();              
        DCScript = GameObject.Find("Player").GetComponent<DetectCollision>();

        Physics.gravity *= gravityModifier;
    }

    // Update is called once per frame
    void Update()
    {
        // make player jump;
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround && !DCScript.gameOver)
        {
            playerRB.AddForce(Vector3.up * forceAdded, ForceMode.Impulse);
            isOnGround = false;
        }

        // make player shoot with the ball after pressing "S";
        if (Input.GetKeyDown(KeyCode.S) && !DCScript.gameOver)
        {
            ballPos = transform.position + ballLocationToAdd;
            Instantiate(ball, ballPos, ball.transform.rotation);
        }

        
    }
      
    // checks if player is on the ground;
    private void OnCollisionEnter(Collision collision)

    {
        isOnGround = true;
    }
}
