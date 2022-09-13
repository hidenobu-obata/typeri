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

int score;
    [SerializeField] Text scoreText;

bool gameOver;

    void Start()
    {
        timeCount = 85;
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

        // Type == Number ÇÃèÍçá
naichilab.RankingLoader.Instance.SendScoreAndShowRanking (score);
    }

    public void OnRetryButton()

{
    SceneManager.LoadScene("Main");

}

void Correct()
    {
        score += 400;
     
        scoreText.text =  score;
    }

    // ä‘à·Ç¶ópÇÃä÷êî
    void Miss()
    {
        score -= 10;
        scoreText.text =  score;
       
    }


void Update()
    {
    if(gameOver)
    {
    return;

    }


    }

}