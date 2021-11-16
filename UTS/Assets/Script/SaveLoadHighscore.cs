using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveLoadHighscore : MonoBehaviour
{
	public Text teksHighScore;
    // Start is called before the first frame update
    void Start()
    {
        teksHighScore.text = "Highscore = " + LoadHighScore().ToString();
    }

    public static int LoadHighScore()
    {
    	int hg=0;
    	if(!PlayerPrefs.HasKey ("BestScore"))
    		PlayerPrefs.SetInt ("BestScore",0);
    	else
    		hg = PlayerPrefs.GetInt ("BestScore");
    	return hg;
    }

    public static void SaveHighScore(int score)
    {
    	int hg = 0 ;
    	if (!PlayerPrefs.HasKey ("BestScore"))
    		PlayerPrefs.SetInt ("BestScore", 0);
    	else {
    		hg = PlayerPrefs.GetInt ("BestScore");
    		if(hg>=score)
    		hg += score;
    		PlayerPrefs.SetInt ("BestScore", hg);
    	}
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
