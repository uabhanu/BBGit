using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelLoader : MonoBehaviour
{
    [SerializeField] GameObject[] m_levelPrefabs;
    GameObject m_levelToLoad;
    [SerializeField] int m_playerLevel;

    void Reset()
    {
        m_playerLevel = 0;
    }

    void Start()
    {
        BrickBlock.m_breakableBricksCount = 0;

        m_levelToLoad = GameObject.FindGameObjectWithTag("Level");

        if(m_levelToLoad == null)
        {
            m_levelToLoad = Instantiate(m_levelPrefabs[m_playerLevel] , transform.position , Quaternion.identity); 
        }
    }
}
