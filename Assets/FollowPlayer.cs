using UnityEngine;
using UnityEngine.SceneManagement;

public class FollowPlayer : MonoBehaviour {

	public Transform player;

	public Camera cam;


	public float speed = 1f;

	int flag = 0;

	void Start()
	{
		cam.backgroundColor=new Color(0,0,0);
	}
	void Update ()
	{
		if(transform.position.x<100)
		{
			cam.backgroundColor=new Color(1.78f*transform.position.x /255,2.3f*transform.position.x/255,2.11f*transform.position.x/255);
		}
		
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
