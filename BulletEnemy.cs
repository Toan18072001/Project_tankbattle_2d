using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletEnemy : MonoBehaviour
{
    [SerializeField]
    float speed = 1f;
    [SerializeField]
    GameObject fire;
    // public Transform enemy;
    private void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position += transform.up * Time.deltaTime * speed;

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "wall")
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
            Instantiate(fire, transform.position, fire.transform.rotation);
        }
        if (collision.CompareTag("notwall"))
        {
            Destroy(gameObject);
            Instantiate(fire, transform.position, fire.transform.rotation);
        }
        if (collision.CompareTag("Player"))
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
            Instantiate(fire, transform.position, fire.transform.rotation);
        }
    }
}
