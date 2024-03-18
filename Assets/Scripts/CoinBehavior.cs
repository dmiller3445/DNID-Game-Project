using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinBehavior : MonoBehaviour
{
    public GameManager GM;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "PF Player")
        {
            GM.CollectCoins();
            Destroy(gameObject);
        }
    }

    private void Update()
    {
    }
}
