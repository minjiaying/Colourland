using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow : MonoBehaviour {

	// Use this for initialization

	public float speed = 1f;
	int flag = 0;


	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Jump") || Input.GetMouseButtonDown(0))
		{
			flag=1;
		}
		if(flag == 1)
		{
			transform.Translate(Vector2.right*speed * Time.deltaTime);
		}
	}
}
