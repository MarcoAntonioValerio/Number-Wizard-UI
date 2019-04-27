using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scp_SceneLoader : MonoBehaviour
{
    
    public float timer = 5f;
    private float timeElapsed;
    

    private void Update()
    {
        int CurrentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        timeElapsed += Time.deltaTime;
        if (CurrentSceneIndex == 0)
        {
            if (timeElapsed > timer)
            {
                LoadNextScene();
            }
        }       
    }

    public void LoadNextScene()
    {
        int CurrentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(CurrentSceneIndex + 1);
        
    }

    public void StartNewGame()
    {
        SceneManager.LoadScene(1);
    }
    
    
}
