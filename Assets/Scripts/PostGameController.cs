using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PostGameController : MonoBehaviour
{
    public void playGame()
    {
        SceneManager.LoadScene("Main_Menu");
    }
}
