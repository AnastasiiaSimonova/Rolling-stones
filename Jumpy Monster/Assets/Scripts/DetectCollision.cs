using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    public bool gameOver = false;    

    
    private void OnCollisionEnter(Collision collision)
    {
        // game is over if player touches the stone;
        if (collision.gameObject.CompareTag("stone"))
        {
            gameOver = true;
            Debug.Log("Game Over!");
        } else if (collision.gameObject.CompareTag("Ball"))
        {
            if (!gameObject.CompareTag("Player"))
            {
                Destroy(gameObject);                        
            }

        } else if (collision.gameObject.CompareTag("Crystal"))
        {
            if (!gameObject.CompareTag("Player"))
            {                
                Destroy(gameObject);
            }

        }
    }
}
