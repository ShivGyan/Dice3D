using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceScriptTwo : MonoBehaviour
{
    // this is applied for (sin cos) cube 
    static Rigidbody rb;

	bool IsGrounded;
	public static Vector3 diceVelocity;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
	}

	// this is the jump key function (used by the button option)
	public float jumpSpeed =5;
	public float force = 200;
	public void jump()
    {
    
	
		rb.AddForce(0, jumpSpeed, 0 , ForceMode.Impulse);
		transform.rotation = Quaternion.identity;
		rb.AddForce (transform.up * force);
		float dirX = Random.Range (0, 500);
		float dirY = Random.Range (0, 500);
		float dirZ = Random.Range (0, 500);
		rb.AddTorque (dirX, dirY, dirZ);
		
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
}
