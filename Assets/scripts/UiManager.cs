using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UiManager : MonoBehaviour
{
    public static UiManager instance;



    public GameObject TapoPanel;
    public GameObject GameOverPanel;
    public Text score;
    public Text higScore1;
    public Text higScore2;
    public GameObject taptext;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        higScore1.text = "High Score:"  + PlayerPrefs.GetInt("highscore");
        
    }

    public void GameStart()
    {
        
        taptext.SetActive(false);
        TapoPanel.GetComponent<Animator> ().Play ("panelUp");
    }
  
    public void GameOver()
    {
        score.text = PlayerPrefs.GetInt("score").ToString();;
        higScore2.text = PlayerPrefs.GetInt("highscore").ToString();;
        GameOverPanel.SetActive(true);
    }

    public void Reset()
    {
        SceneManager.LoadScene(0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
