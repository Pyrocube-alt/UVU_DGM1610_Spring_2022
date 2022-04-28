using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI gameOverText;
    public TextMeshProUGUI cropLeftOverText;
    public TextMeshProUGUI killedText;
    public Button restartButton;
    private PlayerController playerScript;

    private int score;
    private int kill;
    
    

    // Start is called before the first frame update
    void Start()
    {
        playerScript = GameObject.Find("Player").GetComponent<PlayerController>();

        score = 9;   
        UpdateKill(0);
        UpdateScore(0);
    }

    // Update is called once per frame
    void Update()
    {
        GameOver();
    }

    void GameOver()
    {
         if (playerScript.isGameOver == true)
        {
            gameOverText.gameObject.SetActive(true);
            restartButton.gameObject.SetActive(true);
        }
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(0);
    }

    public void UpdateScore(int scoreToSubtract)
    {
        score -= scoreToSubtract;
        cropLeftOverText.text = "CROPS LEFT: " + score;
    }

    public void UpdateKill(int killToAdd)
    {
        kill += killToAdd;
        killedText.text = kill.ToString();
    }
}
