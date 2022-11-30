using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI puntuacion;
    public TextMeshProUGUI tiempo;
    public TextMeshProUGUI vidas;
    public TextMeshProUGUI gameover;

    public GameObject startButton;

    public float startTime;

    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        puntuacion.text = GameManager.instance.puntuacion.ToString();
        vidas.text = GameManager.instance.vidas.ToString();
        tiempo.text = (Time.time - startTime).ToString("00:00");

        if (GameManager.instance.vidas <= 0) 
        {
            gameover.gameObject.SetActive(true);
        }


    }

    public void StartGame()
    {
        Debug.Log("GameStarted");
        startButton.SetActive(false);
        GameManager.instance.StartGame();
    }

    public void RestartGame() 
    {
        Debug.Log("Game Re-Started");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
