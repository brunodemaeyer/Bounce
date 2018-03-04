using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public float speed;
    private Rigidbody rbPlayer;

	// Use this for initialization
	void Start ()
    {
        rbPlayer = GetComponent<Rigidbody>();	
	}
	

	void FixedUpdate ()
    {
        float xMovement = Input.GetAxis("Horizontal");
        float zMovement = Input.GetAxis("Vertical");
        float yMovement = Input.GetAxis("Fire1");

        Vector3 move = new Vector3(xMovement, yMovement, zMovement);
        rbPlayer.AddForce(move*speed);
	}
}
