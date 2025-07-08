using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class count : MonoBehaviour
{
    public static count instance;
   
    public Text scoreText;
    public int score = 0;
    public static int fscore = 0;

    private void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        fscore = 0;
        scoreText.text = score.ToString() + " Coins collected";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void increase()
    {
        score += 1;
        scoreText.text = score.ToString() + " Coins collected";
        fscore = score;
      
    }

}
