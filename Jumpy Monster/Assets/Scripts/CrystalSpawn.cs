using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrystalSpawn : MonoBehaviour
{

    public GameObject[] crystals;
    private DetectCollision DCScript;

    private float startTime = 5;
    private float repeatRate = 4;
    private float xPos = 0.88f;
    private float zPos = 50;

    // Start is called before the first frame update
    void Start()
    {
        DCScript = GameObject.Find("Player").GetComponent<DetectCollision>();
        InvokeRepeating("CrystalsSpawn", startTime, repeatRate);
    }

    // spawns random crystal;
    void CrystalsSpawn()
    {                
        if (!DCScript.gameOver)
        { 
        Instantiate(crystals[createRandomIndex()], new Vector3(xPos, createRandomYPosition(), zPos), transform.rotation);
        }
    }

    // creates random Y position in a range from 5 to 12;
    float createRandomYPosition()
    {
        float yPos = Random.Range(5, 12);
        return yPos;
    }

    // creates random index for the crystals array; 
    int createRandomIndex()
    {
        int randomIndex = Random.Range(0, crystals.Length);
        return randomIndex;
    }
}
