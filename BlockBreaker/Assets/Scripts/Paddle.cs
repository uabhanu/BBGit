using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
	void Start()
    {
		
	}
	
	void Update()
    {
        float mousePosition = (Input.mousePosition.x / Screen.width) * 16;
        Vector3 paddlePosition = new Vector3(0.5f , transform.position.y , 0f);
        paddlePosition.x =Mathf.Clamp(mousePosition , 0.5f , 15.5f);
        transform.position = paddlePosition;
	}
}
