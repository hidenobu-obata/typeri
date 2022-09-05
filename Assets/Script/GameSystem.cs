using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameSystem : MonoBehaviour
{

[SerializeField] Text timerText = default;
int timeCount;

[SerializeField] GameObject resultPanel = default;

bool gameOver;

    void Start()
    {
        timeCount = 90;
        SoundManager.instance.PlayBGM(SoundManager.BGM.Main);
        StartCoroutine(CountDown());
        
    }

   IEnumerator CountDown()
    {
        while (timeCount > 0)
        {

        yield return new WaitForSeconds(1);
        timeCount--;
        timerText.text = timeCount.ToString();
        }
        Debug.Log("timeup");
        gameOver = true;

        resultPanel.SetActive(true);

    }

    public void OnRetryButton()

{
    SceneManager.LoadScene("Main");

}

void Update()
    {
    if(gameOver)
    {
    return;

    }


    }

}