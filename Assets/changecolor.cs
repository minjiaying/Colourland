using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changecolor : MonoBehaviour {

	// Use this for initialization

	public string currentColor;

	public Color c0;
	public Color c1;
	public Color c2;
	public Color c3;

	public GameObject go;

	public Transform cam;

	public SpriteRenderer sr;
	void Start () {
		SetRandomColor(4);
	}
	
	// Update is called once per frame
	void Update () {
		if (cam.position.x - transform.position.x > 10 )
		{
			transform.position = new Vector3(transform.position.x +24,transform.position.y, transform.position.z);
		}
	}

	void SetRandomColor (int n)
	{
		int index = Random.Range(0, n)%n;

		switch (index)
		{
			case 0:
				currentColor = "c0";
				sr.color = c0;
				break;
			case 1:
				currentColor = "c1";
				sr.color = c1;
				break;
			case 2:
				currentColor = "c2";
				sr.color = c2;
				break;
			case 3:
				currentColor = "c3";
				sr.color = c3;
				break;
		}

		go.tag = currentColor;
	}
	
}
