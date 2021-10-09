using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    private int ringScore = 0;
    private int scoreToAdd = 50;
    private BallMovement ballMovement;


    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "" + ringScore;
        ballMovement = FindObjectOfType<BallMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = ringScore.ToString();
    }

    public void AddScore()
    {
        ringScore += scoreToAdd;
    }

}
