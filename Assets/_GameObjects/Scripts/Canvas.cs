using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Canvas : MonoBehaviour {
    public Text txtScore;
    public Image[] imgLives;
    [SerializeField] GameObject panelBack;
        

    void Start () {
        foreach (Image img in imgLives) {
            img.enabled = false;
        }
        //panelBack.SetActive(false);
    }

    void Update()
    {

        txtScore.text = GameManager.Points.ToString();
        for (int i = 0; i < GameManager.Lives; i++)
        {
            if (GameManager.Lives <= 3)
            {
                print(GameManager.Lives);
                imgLives[i].enabled = true;
            }
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            print("he presionado esc");
            panelBack.SetActive(true);

            if (!panelBack.activeSelf)
            {
                Time.timeScale = 1;
            }
            else
            {
                Time.timeScale = 0;
                panelBack.SetActive(false);
            }
        }
    }

    public void ExitToMainMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("MenuScene");
    }

    public void ContinuePlaying()
    {
        panelBack.SetActive(false);
        Time.timeScale = 1;
    }

}



