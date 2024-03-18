using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitboxFlip : MonoBehaviour
{
    private Vector2 newPos;
    private float x, y;
    private float timeElapsed = 0;

    // Update is called once per frame
    void Update()
    {
        x = gameObject.transform.position.x;
        y = gameObject.transform.position.y;
        timeElapsed += Time.deltaTime;
        if (timeElapsed >= 2f && timeElapsed <= 4f)
        {
            transform.eulerAngles = new Vector3(0, 180, 0);
        }
        else if (timeElapsed >= 4f)
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
            timeElapsed = 0;
        }
        newPos = new Vector2(x, y);
        gameObject.transform.position = newPos;

    }
}
