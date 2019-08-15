using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour {

	// Use this for initialization
	public Transform came;

    Vector3  distance;
	void Start () {
		distance = transform.position - came.position;
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = came.position + distance;
	}
}
