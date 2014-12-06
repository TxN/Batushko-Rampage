using UnityEngine;
using System.Collections;

public class Character : MonoBehaviour {

	public SpriteRenderer front;
	public SpriteRenderer back;
	public SpriteRenderer left;
	public SpriteRenderer right;

	public int dir = 1;
	public int startDir = 1;

	public Collider2D chrCol;

	public int hp = 100;

	public float moveSpd = 1;

	public Vector2 sightDir;


	void Start () {
		SetDirection (startDir);
	}
	

	void FixedUpdate () {
	
	}

	public void SetDirection(int d) {
		if (d == 1) {
			sightDir = new Vector2 (0, -1);
			front.enabled = true;
			back.enabled = false;
			left.enabled = false;
			right.enabled = false;
		}

		if (d == 2) {
			sightDir = new Vector2 (-1, 0);
			front.enabled = false;
			back.enabled = false;
			left.enabled = true;
			right.enabled = false;
		}

		if (d == 3) {
			sightDir = new Vector2 (0, 1);
			front.enabled = false;
			back.enabled = true;
			left.enabled = false;
			right.enabled = false;
		}

		if (d == 4) {
			sightDir = new Vector2 (1, 0);
			front.enabled = false;
			back.enabled = false;
			left.enabled = false;
			right.enabled = true;
		}
	}

	public void MoveTo(int d) {
		if (d == 1) {
			SetDirection (d);
			rigidbody2D.AddForce(new Vector2(0, -moveSpd));
		}

		if (d == 2) {
			SetDirection (d);
			rigidbody2D.AddForce(new Vector2(-moveSpd, 0));
		}

		if (d == 3) {
			SetDirection (d);
			rigidbody2D.AddForce(new Vector2(0, moveSpd));
		}

		if (d == 4) {
			SetDirection (d);
			rigidbody2D.AddForce(new Vector2(moveSpd, 0));
		}

	}


}
