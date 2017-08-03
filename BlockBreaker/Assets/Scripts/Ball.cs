using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ball : MonoBehaviour
{
    [SerializeField] string name;

    void OnTriggerEnter2D(Collider2D col2D)
    {
        if(col2D.gameObject.tag.Equals("GameOver"))
        {
            SceneManager.LoadScene(name);
        }
    }
}
