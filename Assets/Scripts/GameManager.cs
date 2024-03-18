using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text Score;
    public int CoinsCollected = 0;


    public void CollectCoins()
    {
        CoinsCollected += 1;
    }
    public void NextLevel()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }

    void Update()
    {
        if (CoinsCollected >= 12)
        {
            UnityEditor.EditorApplication.isPlaying = false;
        }
        Score.text = "Found: " + CoinsCollected + "/12";
    }
}
