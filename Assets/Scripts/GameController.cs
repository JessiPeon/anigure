using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public int health;
    public TextMeshProUGUI healthGUI;
    public AudioSource music;

    //win
    public GameObject winText;
    public GameObject restartButton;
    public GameObject car;
    public GameObject spawner;
    public bool win = false;

    void Start()
    {
        health = 1000;
        music = FindObjectOfType<AudioSource>();
    }

    void Update()
    {
        healthGUI.text = health.ToString();
        if (health <=0)
        {
            SceneManager.LoadScene("BadFinal");
        }

        if (!music.isPlaying)
        {
            //win
            winText.SetActive(true);
            GameObject[] gos = GameObject.FindGameObjectsWithTag("Looped");
            for (int i = 0; i < gos.Length; i++)
            {
                gos[i].GetComponent<RepeatingBG>().speed = 0;
            }
            GameObject[] pozos = GameObject.FindGameObjectsWithTag("Pozo");
            for (int i = 0; i < pozos.Length; i++)
            {
                pozos[i].GetComponent<Pozo>().speed = 0;
            }
            car.transform.Translate(Vector2.left * 3 * Time.deltaTime);
            spawner.SetActive(false);
            restartButton.SetActive(true);
            win = true;
        }
    }
}
