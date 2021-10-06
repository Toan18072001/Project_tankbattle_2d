using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    GameObject enemy;
    private BoxCollider2D box;
    int dem=0;
    private void Start()
    {
        check();
    }
    private void Awake()
    {
        box = GetComponent<BoxCollider2D>(); 
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator spawnerEnemy()
    {
        yield return new WaitForSeconds(Random.Range(5.0f,7.5f));
        float box_Y = box.bounds.size.y;
        Vector3 temp = transform.position;
        temp.y = box_Y;
        Instantiate(enemy, temp, Quaternion.identity);
        StartCoroutine(spawnerEnemy());
    }
    void check()
    {
        if (dem <= 2)
        {
            StartCoroutine(spawnerEnemy());
            dem++;
        }
        else Debug.Log("hơn r");
     }
}
