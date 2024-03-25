using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightGuardController : MonoBehaviour
{
    private Vector2 newPos;
    private float x, y;
    private int direction = 1;
    private float speed = 3;


    // Update is called once per frame
    private void FixedUpdate()
    {
        x = gameObject.transform.position.x;
        y = gameObject.transform.position.y;
        if (gameObject.transform.position.x <= -1.2f && gameObject.transform.position.y <= -4.75f) // Move Right
        {
            x = gameObject.transform.position.x + direction * (speed * Time.deltaTime);
        }

        if (gameObject.transform.position.x >= -1.2f && gameObject.transform.position.y <= -1f) // Move Up
        {
            y = gameObject.transform.position.y + direction * (speed * Time.deltaTime);
        }
        if (gameObject.transform.position.x >= -11f && gameObject.transform.position.y >= -1.1f) // Move Left
        {
            x = gameObject.transform.position.x - direction * (speed * Time.deltaTime);
        }
        if (gameObject.transform.position.x <= -11f && gameObject.transform.position.y >= -4.75f) // Move Down
        {
            y = gameObject.transform.position.y - direction * (speed * Time.deltaTime);
        }

        newPos = new Vector2(x, y);
        gameObject.transform.position = newPos;
    }
}
