using UnityEngine;

public class translate : MonoBehaviour {

	public float speed = 1f;

	public int right = 1;

	public int rx=3;
	public int lx=-12;
	
	// Update is called once per frame
	void Update () {
		if(right==1)
		{
			transform.Translate(Vector2.right*speed * Time.deltaTime);
			if(transform.position.y>rx)
			{
				right = 0;
			}
		}
		else
		{
			transform.Translate(Vector2.left*speed * Time.deltaTime);
			if(transform.position.y<lx)
			{
				right = 1;
			}
		}
		
	}
}
