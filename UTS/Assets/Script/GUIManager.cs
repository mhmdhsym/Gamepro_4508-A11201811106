using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;

public class GUIManager : MonoBehaviour
{
        public Button bEasy;
    public Button bMed;
    public Button bHard;
    // Start is called before the first frame update
    void Start() {
        try{
            LoadButtonLevel ();
            int levelstate = LoadLevel ();
            switch (levelstate) {
            case 0:
                bEasy.interactable = true;
                break;
            case 1:
                bEasy.interactable = true;
                bMed.interactable = true;
                break;
            case 2:
                bEasy.interactable = true;
                bMed.interactable = true;
                bHard.interactable = true;
                break;
            }
        }
        catch(NullReferenceException e){

        }
    }

    public static int LoadLevel()
    {
        int hg=0;
        if (!PlayerPrefs.HasKey ("level"))
            PlayerPrefs.SetInt ("level", 0);
        else
            hg = PlayerPrefs.GetInt ("level");
        return hg;
    }

    public static void saveLevel(int lvl)
    {
        if (!PlayerPrefs.HasKey ("level"))
            PlayerPrefs.SetInt ("level", 0);
        else
            PlayerPrefs.SetInt ("level", lvl);
    }

    void LoadButtonLevel()
    {
        bEasy = GameObject.Find ("Easy").GetComponent<Button>();
        bMed = GameObject.Find ("Medium").GetComponent<Button>();
        bHard = GameObject.Find ("Hard").GetComponent<Button>();
        bEasy.interactable = bMed.interactable = bHard.interactable = false;
    }

    public void OnPlay()
    {
    	SceneManager.LoadScene ("Multilevel");
    }
    public void OnCredits()
    {
        SceneManager.LoadScene ("Credits");
    }

    public void OnLevel1()
    {
    	SceneManager.LoadScene ("Game");
    }

    public void OnLevel2()
    {
    	SceneManager.LoadScene ("Medium");
    }

    public void OnLevel3()
    {
    	SceneManager.LoadScene ("Hard");
    }    

    public void OnHelp()
    {
        SceneManager.LoadScene ("Help");
    }

    public void OnBack()
    {
        SceneManager.LoadScene ("Main");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
