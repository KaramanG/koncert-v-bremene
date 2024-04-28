using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseScript : MonoBehaviour
{
    public bool isPaused;
    public bool isContinue;
    [SerializeField] AudioSource source;
    [SerializeField] GameObject pauseScreen;
    [SerializeField] GameObject settingsScreen;

    private void Start()
    {
        isPaused = false;
        isContinue = false;
        pauseScreen.gameObject.SetActive(false);
        settingsScreen.gameObject.SetActive(false);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PauseGame();
        }
    }

    public void PauseGame()
    {
        if (!isPaused)
        {
            Time.timeScale = 0f;

            source.Pause();
            pauseScreen.gameObject.SetActive(true);

            isPaused = true;
        }
        else
        {
            Time.timeScale = 1;

            source.UnPause();
            pauseScreen.gameObject.SetActive(false);
            settingsScreen.gameObject.SetActive(false);

            isPaused = false;
        }
    }

    public void Settings()
    {
        if (!isContinue)
        {
            settingsScreen.gameObject.SetActive(true);
            pauseScreen.gameObject.SetActive(false);

            isContinue = true;
        }
        else
        {
            settingsScreen.gameObject.SetActive(false);
            pauseScreen.gameObject.SetActive(true);

            isContinue = false;
        }
    }

    [SerializeField] Conductor conductor;
    public void BackToMenu()
    {
        conductor.songSelected = false;
        SceneManager.LoadScene("StartScreen");
    }
}
