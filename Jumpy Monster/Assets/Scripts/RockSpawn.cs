using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockSpawn : MonoBehaviour
{

    public GameObject stone;
    private Vector3 stoneLocation = new Vector3(0, 1, 70);
    private DetectCollision DCScript;
    private float startPause = 2;
    private float repeatRate = 4;
    // Start is called before the first frame update
    void Start()
    {
        DCScript = GameObject.Find("Player").GetComponent<DetectCollision>();
        InvokeRepeating("StoneSpawn", startPause, repeatRate);
    }
    
    // creates stones at stoneLocation;
    private void StoneSpawn()
    {
        if (!DCScript.gameOver) { 
        Instantiate(stone, stoneLocation, stone.transform.rotation);
        }
    }
}
