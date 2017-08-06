using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickBlock : MonoBehaviour
{
    [SerializeField] int m_hitsTaken , m_maxHits;
    [SerializeField] Sprite[] m_brickSprites;
    SpriteRenderer m_brickRenderer;

	void Start()
    {
		m_brickRenderer = GetComponent<SpriteRenderer>();
	}
	
	void Update()
    {
		if(m_hitsTaken >= m_maxHits)
        {
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
        if(col2D.gameObject.tag.Equals("Ball"))
        {
            m_hitsTaken++;
        }
    }
}
