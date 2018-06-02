using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeRotator : MonoBehaviour {

	public Vector3 rotAngles;
	public int rotOffset;
	public int speed;

	// Use this for initialization
	void Start () {
		transform.Rotate(new Vector3(rotAngles.x * rotOffset, rotAngles.y * rotOffset, rotAngles.z * rotOffset));
	}

	// Update is called once per frame
	void Update () {
		transform.Rotate (rotAngles * (Time.deltaTime * speed));
	}
}
