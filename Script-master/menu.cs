using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    public void LoadScene(int indexScene)
    {
        SceneManager.LoadSceneAsync(indexScene);
    }

    public void ExitGame()
    {
        Application.Quit();
        Debug.Log("Is exit");
    }

}
