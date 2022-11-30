using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public static GameManager instance;

    public GameObject game;

    public int vidas = 3;
    public int puntuacion = 0;
    private void Start()
    {
        Time.timeScale = 0;
    }

    // Update is called once per frame
    void Update()
    {
        instance = this;

    }

    public void StartGame()
    {
        game.SetActive(true);
        Time.timeScale = 1;
    }
}
