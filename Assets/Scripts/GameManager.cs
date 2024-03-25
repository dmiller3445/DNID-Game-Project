using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
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
        int nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;
        if (SceneManager.sceneCountInBuildSettings > nextSceneIndex)
        {
            SceneManager.LoadScene(nextSceneIndex);
        }
    }

    void Update()
    {

        if (CoinsCollected >= 12)
        {
            Application.Quit(); 

        }
        Score.text = "Found: " + CoinsCollected + "/12";
    }
}
