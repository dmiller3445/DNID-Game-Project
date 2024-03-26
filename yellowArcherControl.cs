using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yellowArcherControl : MonoBehaviour
{
    private Vector2 newPos;
    private float x, y;
    private int direction = 1;
    private float speed = 3;


    // Update is called once per frame
    private void update()
    {
        if (gameObject.transform.position.x >= -6.2f || gameObject.transform.position.x <= -9f)
        {
            direction *= -1;
        }
        x = gameObject.transform.position.x + direction * (speed * Time.deltaTime);
        y = gameObject.transform.position.y;
        newPos = new Vector2(x, y);
        gameObject.transform.position = newPos;
    }
}
    