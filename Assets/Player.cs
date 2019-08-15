using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour {

	public float jumpForce = 10f;
	public float right0 = 1.25f;

	public float right1 = 1f;

	public float G = 3f;

	public Rigidbody2D rb;
	public SpriteRenderer sr;

	public Transform cam;

	public string currentColor;

	public Color c0;
	public Color c1;
	public Color c2;
	public Color c3;

	public int life=20;

	public int score=0;

	public GameObject ttl;

	public GameObject tts;

	public AudioClip loselife;

	public AudioClip die;

	private AudioSource source;
	Vector2 vx;

	void Start ()
	{
		
		SetRandomColor(4);
		source = GetComponent<AudioSource>(); 

		rb.velocity =Vector2.zero;
		rb.gravityScale = 0;

		vx = Vector2.right* right0;

		ttl.GetComponent<Text>().text=life.ToString();
		tts.GetComponent<Text>().text=score.ToString();
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.x< cam.position.x + 5)
		{
			vx = Vector2.right* right0;
		}
		else
		{
			vx = Vector2.right* right1;
		}

		if (Input.GetButtonDown("Jump") || Input.GetMouseButtonDown(0))
		{
			rb.velocity = Vector2.up * jumpForce + vx;
			rb.gravityScale = G;
		}

		score = (int) cam.position.x;

		tts.GetComponent<Text>().text=score.ToString();
	}

	void OnTriggerEnter2D (Collider2D col)
	{
		if (col.tag == "board")
		{
			rb.velocity = new Vector2(rb.velocity.x,-rb.velocity.y);
			return;
		}


		if (col.tag != currentColor)
		{
			life--;
			Debug.Log("lost life");

			source.PlayOneShot(loselife, 1F); 
			
			switch (col.tag)
			{
			case "c0":
				currentColor = "c0";
				sr.color = c0;
				break;
			case "c1":
				currentColor = "c1";
				sr.color = c1;
				break;
			case "c2":
				currentColor = "c2";
				sr.color = c2;
				break;
			case "c3":
				currentColor = "c3";
				sr.color = c3;
				break;
			}
			
			if(ttl!=null)
			{
			ttl.GetComponent < Text >().text = life.ToString();
			}
			if(life ==0)
			{
				Debug.Log("GAME OVER!");
				PlayerPrefs.SetInt("Player Score", (int)cam.position.x);
				SceneManager.LoadScene("scene/score");
			}
			
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
	}
}
