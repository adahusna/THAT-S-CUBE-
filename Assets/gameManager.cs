using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour
{
    bool gameEnded = false;
    public float delayTime = 2f;
    public GameObject LevelUI;
       
        

        public void GameOver()
    {
        if (gameEnded == false) // first time our GameOver method is called gameEnded will be false so this statement will be true
        {
            gameEnded = true;
            Debug.Log("GAME OVER");
            Invoke("RestartGame", delayTime);         //instead of immedately calling our RestartGame function, we use Invoke to wait a bit before the start
        }
    }


    public void RestartGame ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);


    }

    public void Level()
    {
        
        LevelUI.SetActive(true);
    }


}
