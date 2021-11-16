using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
	public Text ScoreText;

	float score;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        score+=100*Time.deltaTime;
        ScoreText.text="Score: "+(int)score;
        
        if (score >= 2000)
        GUIManager.saveLevel (1);
        if (score >= 5000)
        GUIManager.saveLevel (2);
        if(PlayerPrefs.GetInt("BestScore")<score)
        {
        	PlayerPrefs.SetInt("BestScore",(int)score);
    	}       
    }
}
