using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public void BrickDestroyed()
    {
        if(BrickBlock.m_breakableBricksCount <= 0)
        {
            LoadScene("Win");
        }
    }

    public void LoadScene(string name)
    {
        Debug.Log("StartButton Pressed");
        SceneManager.LoadScene(name);
    }

    public void Quit()
    {
        Debug.Log("QuitButton Pressed");
    }
}
