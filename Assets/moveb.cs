using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveb : MonoBehaviour {

	// Use this for initialization
	public Transform cam;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (cam.position.x - transform.position.x > 20 )
		{
			transform.position = new Vector3(transform.position.x +80,transform.position.y, transform.position.z);
		}
	}
}
