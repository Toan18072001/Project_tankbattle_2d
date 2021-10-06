using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    public GameObject key_lv1;
    public GameObject key_lv2;
    // Update is called once per frame
    void start()
    {
        if(Enemy.instance.dem >= 10)
        {
            key_lv1.SetActive(false);
        }
    }
}
