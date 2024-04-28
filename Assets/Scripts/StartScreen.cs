using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScreen : MonoBehaviour
{
    [SerializeField] GameObject title;
    Transform originalPos;
    float sinOffset;

    private void Start()
    {
        originalPos = title.transform;
    }
    private void Update()
    {
        sinOffset = Mathf.Sin(Time.time * 2);

        title.transform.position = new Vector2(
            originalPos.position.x,
            originalPos.position.y + sinOffset * 0.0005f);
    }
    public void StartGame()
    {
        SceneManager.LoadScene("MainScene");
    }

    public void EndGame()
    {
        Application.Quit();
    }
}
