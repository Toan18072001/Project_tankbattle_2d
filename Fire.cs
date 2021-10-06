using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine(die());
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")/*|| collision.CompareTag("Enemy")*/)
        {
            Destroy(collision.gameObject);
            UI_game.instance.Game_over.SetActive(true);
        }
    }
    IEnumerator die()
    {
        yield return new WaitForSeconds(Random.Range(5.0f, 7.5f));
        Destroy(gameObject);
    }
}
