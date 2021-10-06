using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet: MonoBehaviour
{
    public static Bullet intance;
    [SerializeField]
    float speed = 1f;
    [SerializeField]
    GameObject fire;
    public string direction="up";
    int dem = 0;
    // public Transform enemy;
    private void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        if(direction == "left")
        {
            GetComponent<Transform>().position += new Vector3(-speed * Time.deltaTime, 0, 0);
        }
        if (direction == "right")
        {
            GetComponent<Transform>().position += new Vector3(speed * Time.deltaTime, 0, 0);
        }
        if (direction == "up")
        {
            GetComponent<Transform>().position += new Vector3(0, speed * Time.deltaTime, 0);
        }
        if (direction == "dowm")
        {
            GetComponent<Transform>().position += new Vector3(0, -speed * Time.deltaTime, 0);
        }
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
        if (collision.CompareTag("Enemy"))
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
            Instantiate(fire, transform.position, fire.transform.rotation);
            dem++;
            Debug.Log(dem);
            if (dem == 10)
            {
                UI_game.instance.Game_Win.SetActive(true);
            UI_game.instance.key_lv1.SetActive(false);
               
            }
        }
    }
}
