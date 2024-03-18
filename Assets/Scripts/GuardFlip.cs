using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuardFlip : MonoBehaviour
{
    private float timeElapsed = 0;
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "PF Player")
        {
            UnityEditor.EditorApplication.isPlaying = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
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


    }

}
