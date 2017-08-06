using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickBlock : MonoBehaviour
{
    [SerializeField] int m_hitsLeft;

	void Start()
    {
		
	}
	
	void Update()
    {
		if(m_hitsLeft == 0)
        {
            this.gameObject.SetActive(false);
        }
	}

    void OnCollisionEnter2D(Collision2D col2D)
    {
        if(col2D.gameObject.tag.Equals("Ball"))
        {
            m_hitsLeft--;
        }
    }
}
