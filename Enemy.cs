using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public static Enemy instance;
    public Rigidbody2D rg;
    [SerializeField]
    float speed,speedbullet;
    int random;
    bool starus = false;
    public Object bullet;
    
    public GameObject _fire;
    public int dem = 0;
    private void Awake()
    {
        instance = this;
    }
    private void Start()
    {
       //  rg = GetComponent<Rigidbody2D>();
        StartCoroutine(_Ran_Rotation());
        StartCoroutine(enemykshot());
        
    }

   

    // Update is called once per frame
    void Update()
    {
        this.transform.position += transform.up * Time.deltaTime * speed;
       
        //checkshot();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("wall")||collision.CompareTag("notwall"))
        {
            random = Random.Range(1, 4);
            Ran_Rotation(random);
        }
        if (collision.CompareTag("taget"))
        {
            Debug.Log("taget");
            starus = true;
        }
        if(collision.tag == "Player")
        {
            Destroy(collision.gameObject);
            Instantiate(_fire, transform.position, _fire.transform.rotation);
           
           
                UI_game.instance.Game_over.SetActive(true); // gọi lại sigleton: <tên lớp chứa sigleton>.<tên biến>.<tên phương thức>();
            
        }
    }
   
    IEnumerator _Ran_Rotation()
    {
        yield return new WaitForSeconds(Random.Range(2.0f, 4.0f));
        random = Random.Range(1, 4);
        Ran_Rotation(random);
        StartCoroutine(_Ran_Rotation());
    }
    void Ran_Rotation(int x)
    {
        if (x == 1)
        {
            this.transform.Rotate(transform.rotation.x, transform.rotation.y, transform.rotation.z + 90);
        }
        if (x == 2)
        {
            this.transform.Rotate(transform.rotation.x, transform.rotation.y, transform.rotation.z + 180);
        }
        if (x == 3)
        {
            this.transform.Rotate(transform.rotation.x, transform.rotation.y, transform.rotation.z + 270);
        }
        if (x == 4)
        {
            this.transform.Rotate(transform.rotation.x, transform.rotation.y, transform.rotation.z + 360);
        }
    }

    IEnumerator enemykshot()
    {
        yield return new WaitForSeconds(1.5f);
        Instantiate(bullet, new Vector3(transform.position.x, transform.position.y, transform.position.z), transform.rotation);

        StartCoroutine(enemykshot());

    }
   

    
  
}
