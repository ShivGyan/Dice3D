using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceScript : MonoBehaviour {

	static Rigidbody rb;
    public float force = 200;
    bool IsGrounded;
	public static Vector3 diceVelocity;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
	}

	// this is the jump key function (used by the button option)
	public float jumpSpeed =5;
	public void jump()
    {
        { if (IsGrounded){
		rb.AddForce(0, jumpSpeed, 0 , ForceMode.Impulse);
		transform.rotation = Quaternion.identity;
		rb.AddForce (transform.up * force);
		float dirX = Random.Range (0, 500);
		float dirY = Random.Range (0, 500);
		float dirZ = Random.Range (0, 500);
		rb.AddTorque (dirX, dirY, dirZ);
		}
	}
	}

	public void Endgame()
	{
		Application.Quit();
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("Ground"))
		{
			IsGrounded = true;
		}
	}

	private void OnTriggerExit(Collider other)
	{
		if (other.CompareTag("Ground"))
		{
			IsGrounded = false;
		}
	}

	
	// Update is called once per frame
	/*void Update () {
		diceVelocity = rb.velocity;

		if (Input.GetKeyDown (KeyCode.Space)) {
			DiceNumberTextScript.diceNumber = 0;
			float dirX = Random.Range (0, 500);
			float dirY = Random.Range (0, 500);
			float dirZ = Random.Range (0, 500);
			transform.position = new Vector3 (0, 2, 0);
			transform.rotation = Quaternion.identity;
			rb.AddForce (transform.up * 500);
			rb.AddTorque (dirX, dirY, dirZ);
		}
	}*/
}
