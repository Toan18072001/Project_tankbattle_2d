using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bonus : MonoBehaviour
{
    private float minX, maxX, minY, maxY;
    public Transform background,player;
    Vector2 check, direction;
   
    void Start()
    {
        direction = player.transform.position;
        check = background.transform.position;
        minX = -check.x;
        maxX = check.x;
        minY = -check.y;
        maxX = check.y;
    }

    // Update is called once per frame
    void Update()
    {
       
        if (direction.x < minX)
        {
            direction.x = minX;
        }
        else
        {
            direction.x = maxX;
        }
        if (direction.y < minY)
        {
            direction.y = minY;
        }
        else
        {
            direction.y = maxY;
        }
        player.transform.position = direction;
    }
}
