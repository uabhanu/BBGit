using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickBlock : MonoBehaviour
{
    [SerializeField] AudioClip m_brickSound;
    bool m_isBreakable;
    public static int m_breakableBricksCount = 0;
    int m_hitsTaken;
    LevelManager m_levelManager;
    [SerializeField] Sprite[] m_brickSprites;
    SpriteRenderer m_brickRenderer;

    void Start()
    {
        m_brickRenderer = GetComponent<SpriteRenderer>();
        m_hitsTaken = 0;
        m_isBreakable = this.tag == "Breakable";
        m_levelManager = FindObjectOfType<LevelManager>();

        if(m_isBreakable)
        {
            m_breakableBricksCount++;
        }
    }

    void HandleHits()
    {
        m_hitsTaken++;
        int m_maxHits = m_brickSprites.Length + 1;    

        if(m_hitsTaken >= m_maxHits)
        {
            m_breakableBricksCount--;
            m_levelManager.BrickDestroyed();
            this.gameObject.SetActive(false);
        }
        else
        {
            LoadSprite();
        }
    }

    void LoadSprite()
    {
        int spriteIndex = m_hitsTaken - 1;
        m_brickRenderer.sprite = m_brickSprites[spriteIndex];
    }

    void OnCollisionEnter2D(Collision2D col2D)
    {
        AudioSource.PlayClipAtPoint(m_brickSound , transform.position);

        if(m_isBreakable)
        {
            HandleHits();
        }
    }
}
