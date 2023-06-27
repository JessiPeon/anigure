using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pozo : MonoBehaviour
{
    public float speed;
    private GameController gameC;
    private void Start()
    {
        gameC = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
    }
    private void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && !gameC.win)
        {
            GameObject.FindGameObjectWithTag("ShakeController").GetComponent<Shake>().activeShake();
            GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>().health -= 200;
        }
    }
}
