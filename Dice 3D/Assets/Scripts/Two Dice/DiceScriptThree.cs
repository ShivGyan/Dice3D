using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceScriptThree : MonoBehaviour
{
    // Start is called before the first frame update
   static Rigidbody rb;
	public static Vector3 diceVelocity;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
	}

	// this is the jump key function (used by the button option)
	public float jumpSpeed =5;
	public void jump()
    {
        rb.AddForce(0, jumpSpeed, 0 , ForceMode.Impulse);
		transform.rotation = Quaternion.identity;
		rb.AddForce (transform.up * 400);
		float dirX = Random.Range (0, 500);
		float dirY = Random.Range (0, 500);
		float dirZ = Random.Range (0, 500);
		rb.AddTorque (dirX, dirY, dirZ);
	}
}
