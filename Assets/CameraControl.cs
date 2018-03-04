using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour {

    public GameObject Player;
    public Vector3 CameraOffset;

	// Use this for initialization
	void Start ()
    {
        CameraOffset = transform.position - Player.transform.position;	
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.position = Player.transform.position + CameraOffset;
	}
}
