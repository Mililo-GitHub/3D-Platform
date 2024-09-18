using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public GameObject pauseMenuUI;
    public GameObject Cube;
    public GameObject Cube2;
    private Scene scene;

    void Start()
    {
        scene = SceneManager.GetActiveScene();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            } else
            {
                Pause();
            }
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (GameIsPaused)
            {
                QuitGame();
            }
            
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (GameIsPaused)
            {
                LoadMenu();
            }

        }
            if (Input.GetKeyDown(KeyCode.N))
            {
            if (GameIsPaused)
                {
                    HandsOff();
                }
                else 
                {
                   
                }

            }
        if (Input.GetKeyDown(KeyCode.H))
        {
            if (GameIsPaused)
            {
                HandsOn();
            }
            else
            {

            }

        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            if (GameIsPaused)
            {
                Restart();
                Resume();
            }
            else
            {

            }

        }
    }

   public void Resume ()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
       

    }
        
    void Pause ()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
       

    }

    public void LoadMenu()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1f;
    }
    
    public void QuitGame()
    {
        Debug.Log("Quitting Game");
        Application.Quit();
    }

    void HandsOn()
    {
       Cube.SetActive(true);
        Cube2.SetActive(true);
    }

    void HandsOff()
    {
       Cube.SetActive(false);
        Cube2.SetActive(false);
    }

    void Restart()
    {
        SceneManager.LoadScene(scene.name);
    }
}
