using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class score : MonoBehaviour {

	// Use this for initialization
	public GameObject tts;
	int fscore;
	void Start () {
		fscore = PlayerPrefs.GetInt("Player Score");
		tts.GetComponent<Text>().text=fscore.ToString();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Jump") || Input.GetMouseButtonDown(0))
		{
			SceneManager.LoadScene("scene/new main");
		}
	}
}
