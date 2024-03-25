using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cainos.PixelArtTopDown_Basic
{
    public class TopDownCharacterController : MonoBehaviour
    {
        private float speed = 4;




        private void Update()
        {
            if (Input.GetKey("escape"))
            {
                Application.Quit();

            }
            Vector2 dir = Vector2.zero;
            if (Input.GetKey(KeyCode.A))
            {
                dir.x = -1;
                GetComponent<SpriteRenderer>().flipX = true;

            }
            else if (Input.GetKey(KeyCode.D))
            {
                dir.x = 1;
                GetComponent<SpriteRenderer>().flipX = false;
            }

            if (Input.GetKey(KeyCode.W))
            {
                dir.y = 1;

            }
            else if (Input.GetKey(KeyCode.S))
            {
                dir.y = -1;

            }

            dir.Normalize();


            GetComponent<Rigidbody2D>().velocity = speed * dir;
        }
    }
}
