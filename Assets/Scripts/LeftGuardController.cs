using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftGuardController : MonoBehaviour
{
    private Vector2 newPos;
    private float x, y;
    private int direction = 1;
    private float speed = 4;

 

    // Update is called once per frame
    private void FixedUpdate()
    {
        x = gameObject.transform.position.x;
        y = gameObject.transform.position.y;
         if (gameObject.transform.position.x <= 14.25f && gameObject.transform.position.y <= 6f) // Move Right
        {
            x = gameObject.transform.position.x + direction * (speed * Time.deltaTime);
        }    

        if (gameObject.transform.position.x >= 14.25f && gameObject.transform.position.y <= 11.4f) // Move Up
        {
            y = gameObject.transform.position.y + direction * (speed * Time.deltaTime);
        }
        if (gameObject.transform.position.x >= 7.2f && gameObject.transform.position.y >= 11.4f) // Move Left
        {
            x = gameObject.transform.position.x - direction * (speed * Time.deltaTime);
        }
        if (gameObject.transform.position.x <= 7.2f && gameObject.transform.position.y >= 6f) // Move Down
        {
            y = gameObject.transform.position.y - direction * (speed * Time.deltaTime);
        }

            newPos = new Vector2(x, y);
            gameObject.transform.position = newPos;
    }
}
