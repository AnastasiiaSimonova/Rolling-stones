using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class MainManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public int score;
    private DetectCollision DCScript;


    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        scoreText.text = "Score: " + score;
        DCScript = GameObject.Find("Player").GetComponent<DetectCollision>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   
    public void UpdateScore()
    {
        score++;
        scoreText.text = "Score: " + score;        
    }
}
