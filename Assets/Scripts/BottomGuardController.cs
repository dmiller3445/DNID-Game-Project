using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottomGuardController : MonoBehaviour
{
    private Vector2 newPos;
    private float x, y;
    private int direction = 1;
    private float speed = 2;


    // Update is called once per frame
    private void FixedUpdate()
    {
        if (gameObject.transform.position.y >= 5 || gameObject.transform.position.y <= -2)
        {
            direction *= -1;
        }
        x = gameObject.transform.position.x;
        y = gameObject.transform.position.y + direction * (speed * Time.deltaTime);
        newPos = new Vector2(x, y);
        gameObject.transform.position = newPos;
    }
}
