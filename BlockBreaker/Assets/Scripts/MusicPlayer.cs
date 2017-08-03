using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    static MusicPlayer m_instance;

    void Awake()
    {
        if(m_instance != null) //Self Destruct if an instance already exists
        {
            Destroy(gameObject);
        }
        else
        {
            m_instance = this; //This is the global instance as in, the Class level instance itself, and don't destroy this
            GameObject.DontDestroyOnLoad(gameObject);
        }
    }
}
