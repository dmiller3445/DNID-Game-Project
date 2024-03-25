using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopGuardController : MonoBehaviour
{
    private Vector2 newPos;
    private float x, y;
    private int direction = 1;
    private float speed = 3;
 

    // Update is called once per frame
    private void FixedUpdate()
    {
        if (gameObject.transform.position.x >= 7.75 || gameObject.transform.position.x <= -0.75)
        {
            direction *= -1;
        }
        x = gameObject.transform.position.x + direction * (speed * Time.deltaTime);
        y = gameObject.transform.position.y;
        newPos = new Vector2(x, y);
        gameObject.transform.position = newPos;
    }
}
