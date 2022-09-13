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

    public static GameSystem Instance { get; private set; }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }
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
        naichilab.RankingLoader.Instance.SendScoreAndShowRanking(score);
    }

    public void OnRetryButton()

    {
        SceneManager.LoadScene("Main");

    }

    public void Correct()
    {
        score += 400;

        scoreText.text = score.ToString();
    }

    public void Miss()
    {
        score -= 10;
        scoreText.text = score.ToString();

    }


    void Update()
    {
        if (gameOver)
        {
            return;

        }


    }

}