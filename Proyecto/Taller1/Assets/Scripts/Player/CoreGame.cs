using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Tienda;

public class CoreGame : MonoBehaviour
{

    #region singleton
    private static CoreGame instance;

    public static CoreGame Instance
    {
        get
        {
            return instance;
        }

    }

    #endregion

    private bool isPaused = false;
    private int actualLevel;
    [SerializeField]
    private int enemiesKilled;

    public int ActualLevel
    {
        get
        {
            return actualLevel;
        }

        set
        {
            actualLevel = value;
        }
    }

    public int EnemiesKilled
    {
        get
        {
            return enemiesKilled;
        }
    }

    private void Start()
    {
        Time.timeScale = 1;
        actualLevel = 1;

        Player.Instance.die += LoseGame;

        new StoreManager();
    }

    public void UpdateEnemiesKilled()
    {
        if (enemiesKilled > 99)
        {
            UpLevel();
        }
        else
        {
            enemiesKilled += 1;
        }
    }

    public void UpLevel() {

        enemiesKilled = 0;
        actualLevel += 1;
    }

    public void LoseGame()
    {
        PauseGame();
    }     


    public void RestartV()
    {
        SceneManager.LoadScene(0);
    }

    public void QuitAPK()
    {
        Application.Quit();
    }



    #region PauseGame VOID
    public void PauseGame()
    {
        if (Time.timeScale == 0)
        {
            Time.timeScale = 1;
            //PausePanel.SetActive(false);
            isPaused = false;
        }
        else
        {
            Time.timeScale = 0;
            //PausePanel.SetActive(true);
            isPaused = true;
        }


    }
    #endregion
}
