﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    Ball m_ballController;
    [SerializeField] bool m_autoPlay;

	void Start()
    {
		m_ballController = GameObject.FindObjectOfType<Ball>();
	}
	
	void Update()
    {
        if(Time.timeScale == 0)
        {
            return;
        }

        if(!m_autoPlay)
        {
            MoveWithMouse();
        }
        else
        {
            AutoPlay();
        }
	}

    void AutoPlay()
    {
        Vector3 ballPosition = m_ballController.transform.position;
        Vector3 paddlePosition = new Vector3(0.5f , transform.position.y , 0f);
        paddlePosition.x = Mathf.Clamp(ballPosition.x , 0.5f , 15.5f);
        transform.position = paddlePosition;
    }

    void MoveWithMouse()
    {
        float mousePosition = (Input.mousePosition.x / Screen.width) * 16;
        Vector3 paddlePosition = new Vector3(0.5f , transform.position.y , 0f);
        paddlePosition.x = Mathf.Clamp(mousePosition , 0.5f , 15.5f);
        transform.position = paddlePosition;
    }
}
