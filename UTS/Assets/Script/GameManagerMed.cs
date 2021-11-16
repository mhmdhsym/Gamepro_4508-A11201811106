using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerMed : MonoBehaviour
{
    public GameObject pausePanel;
    public GameObject gameOverPanel;
    public AudioSource carDrivingSound;
    public AudioSource carCrashSound;
    public GameObject spawner;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Pause()
    {
        spawner.SetActive(false);
        carDrivingSound.Stop();
        pausePanel.SetActive(true);
        Time.timeScale=0;
    }
    public void Resume()
    {
        spawner.SetActive(true);
        SpawnerMed.instance.SpawnAgain();
        carDrivingSound.Play();
        Time.timeScale=1;
        pausePanel.SetActive(false);
    }
    public void Menu()
    {
        Time.timeScale=1;
        SceneManager.LoadScene(0);
    }
    public void GameOver()
    {
        gameOverPanel.SetActive(true);
        Time.timeScale=0;
    }
    public void Restart()
    {
        Time.timeScale=1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        carDrivingSound.Stop();
        carCrashSound.Play();
        GameOver();
    }
}
