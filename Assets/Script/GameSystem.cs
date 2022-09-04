using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameSystem : MonoBehaviour
{
    void Start()
    {
        SoundManager.instance.PlayBGM(SoundManager.BGM.Main);
    }

    public void Retry()
    {
        string thisScene = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(thisScene);
    }
}
