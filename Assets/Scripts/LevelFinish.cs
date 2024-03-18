using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelFinish : MonoBehaviour
{
    public Text Score;
    public int CoinsCollected;
    public GameManager GM;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "PF Player")
        {
            
                GM.NextLevel();
           
        }
    }
}
