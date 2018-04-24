using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour {

	public Rigidbody2D rb;
	public float moveSpeed;
	public float flapHeight;
	public GameObject pipe_up;
	public GameObject pipe_down;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D>();
		BuildLevel ();
	}
	
	// Update is called once per frame
	void Update () {
		rb.velocity = new Vector2 (moveSpeed, rb.velocity.y);

		if (Input.GetMouseButtonDown (0)) {
			rb.velocity = new Vector2 (rb.velocity.x, flapHeight);
		}

		if (transform.position.y > 18 || transform.position.y < -19) {
			Death();
		}
	}

	public void Death() {
		rb.velocity = Vector3.zero;
		transform.position = new Vector2 (0, 0);
	}

	void BuildLevel() {
		Instantiate (pipe_down, new Vector3 (14, 1), transform.rotation);
		Instantiate (pipe_up, new Vector3 (14, -12), transform.rotation);

		Instantiate (pipe_down, new Vector3 (26, 6), transform.rotation);
		Instantiate (pipe_up, new Vector3 (26, -8), transform.rotation);

		Instantiate (pipe_down, new Vector3 (38, 10), transform.rotation);
		Instantiate (pipe_up, new Vector3 (38, -2), transform.rotation);

		Instantiate (pipe_down, new Vector3 (50, 16), transform.rotation);
		Instantiate (pipe_up, new Vector3 (50, 4), transform.rotation);

		Instantiate (pipe_down, new Vector3 (61, 12), transform.rotation);
		Instantiate (pipe_up, new Vector3 (61, 0), transform.rotation);

	}
}
