using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ball : MonoBehaviour
{
    bool m_gameStarted;
    [SerializeField] Paddle m_paddleController;
    Rigidbody2D m_ballBody2D;
    [SerializeField] string m_levelName;
    Vector3 m_paddleToBallDistance;

    void Start()
    {
        m_ballBody2D = GetComponent<Rigidbody2D>();
        m_paddleToBallDistance = transform.position - m_paddleController.transform.position;    
    }

    void Update()
    {
        if(Time.timeScale == 0)
        {
            return;
        }

        if(!m_gameStarted)
        {
            transform.position = m_paddleController.transform.position + m_paddleToBallDistance; //Lock ball position relative to paddle position every frame

            if(Input.GetMouseButtonDown(0))
            {
                m_gameStarted = true; //Use of this boolean is to undo the Lock ball position every frame so ball actually moves around now which is correct
                m_ballBody2D.velocity = new Vector2(2f , 10f);
            }
        }
    }

    void OnTriggerEnter2D(Collider2D col2D)
    {
        if(col2D.gameObject.tag.Equals("GameOver"))
        {
            SceneManager.LoadScene(m_levelName);
        }
    }
}
