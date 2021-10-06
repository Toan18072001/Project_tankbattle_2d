using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : MonoBehaviour
{
    public static Player instance;
    Rigidbody2D rg;
    float Speed=2f;
    public GameObject bullet;
    public Sprite up, left;
    bool status = true;
    [SerializeField]
    Transform spawner;
    private string direction;
    private void Start()
    {
        rg = GetComponent<Rigidbody2D>();
        
    }
    
    public void BtnUp_down()
    {
        transform.Rotate(0, 0, 0);
        rg.velocity = new Vector2(rg.velocity.x, Speed);
        GetComponent<SpriteRenderer>().sprite = up;
        GetComponent<Transform>().localScale = new Vector3(1, 1, 1);
        direction = "up";
        bullet.GetComponent<Bullet>().transform.eulerAngles = new Vector3(0, 0, 0);
    }
    public void BtnUp_up()
    {
        transform.Rotate(0, 0, 0);
        rg.velocity = new Vector2(rg.velocity.x, 0);
       
        GetComponent<SpriteRenderer>().sprite = up;
        GetComponent<Transform>().localScale = new Vector3(1, 1, 1);
        direction = "up";
        bullet.GetComponent<Bullet>().transform.eulerAngles = new Vector3(0, 0, 0);
    }
    public void BtnDown_down()
    {
       
        rg.velocity = new Vector2(rg.velocity.x, Speed*-1);
        GetComponent<SpriteRenderer>().sprite = up;
        GetComponent<Transform>().localScale = new Vector3(1, -1, 1);
        direction = "down";
        bullet.GetComponent<Bullet>().transform.eulerAngles = new Vector3(0, 0, 0);
    }
    public void BtnDown_up()
    {
        rg.velocity = new Vector2(rg.velocity.x, 0);
        GetComponent<SpriteRenderer>().sprite = up;
        GetComponent<Transform>().localScale = new Vector3(1, -1, 1);
        direction = "down";
        bullet.GetComponent<Bullet>().transform.eulerAngles = new Vector3(0, 0, 0);
    }
    public void BtnLeft_down()
    {
        rg.velocity = new Vector2(Speed*-1, rg.velocity.y);
        GetComponent<SpriteRenderer>().sprite = left;
        GetComponent<Transform>().localScale = new Vector3(1, 1, 1);
        direction = "left";
        bullet.GetComponent<Bullet>().transform.eulerAngles = new Vector3(0, 0, 90);
    }
    public void BtnLeft_up()
    {
        rg.velocity = new Vector2(0, rg.velocity.y);
        GetComponent<SpriteRenderer>().sprite = left;
        GetComponent<Transform>().localScale = new Vector3(1, 1, 1);
        direction = "left";
        bullet.GetComponent<Bullet>().transform.eulerAngles = new Vector3(0, 0, 90);
    }
    public void BtnRight_down()
    {
        rg.velocity = new Vector2(Speed , rg.velocity.y);
        GetComponent<SpriteRenderer>().sprite = left;
        GetComponent<Transform>().localScale = new Vector3(-1, 1, 1);
      direction = "right";
        bullet.GetComponent<Bullet>().transform.eulerAngles = new Vector3(0, 0, 90);
    }
    public void BtnRight_up()
    {
        rg.velocity = new Vector2(0, rg.velocity.y);
        GetComponent<SpriteRenderer>().sprite = left;
        GetComponent<Transform>().localScale = new Vector3(-1, 1, 1);
        direction = "right";
        bullet.GetComponent<Bullet>().transform.eulerAngles = new Vector3(0, 0, 90);
    }
    public void Btnshoot_click()
    {
        if (status)
        {
            StartCoroutine(tankshot());
        }
    }


    IEnumerator tankshot()
    {
        status = false;
        Instantiate(bullet,transform.position , Quaternion.identity);
        bullet.GetComponent<Bullet>().direction = direction;
        yield return  new WaitForSeconds(1f);
        status = true;
    }
    public void Spawner_Player()
    {
        Instantiate(gameObject, spawner.transform.position, Quaternion.identity);
    }

}

