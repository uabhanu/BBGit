using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickBlock : MonoBehaviour
{
    int m_hitsTaken;
    [SerializeField] Sprite[] m_brickSprites;
    SpriteRenderer m_brickRenderer;

    void Start()
    {
        m_brickRenderer = GetComponent<SpriteRenderer>();
        m_hitsTaken = 0;
    }

    void LoadSprite()
    {
        int spriteIndex = m_hitsTaken - 1;
        m_brickRenderer.sprite = m_brickSprites[spriteIndex];
    }

    void OnCollisionEnter2D(Collision2D col2D)
    {
        if(col2D.gameObject.tag.Equals("Ball"))
        {
            m_hitsTaken++;
            int m_maxHits = m_brickSprites.Length + 1;    

            if(m_hitsTaken >= m_maxHits)
            {
                this.gameObject.SetActive(false);
            }
            else
            {
                LoadSprite();
            }
        }
    }
}
