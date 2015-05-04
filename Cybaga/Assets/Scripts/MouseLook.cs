using UnityEngine;
using System.Collections;

public class MouseLook : MonoBehaviour 
{

	public float xRotation = 0.0f;
	public float yRotation = 0.0f;

	public float xSensitivity = 5.0f;
	public float ySensitivity = 5.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		xRotation += Input.GetAxis("Mouse X") * xSensitivity;
		yRotation -= Input.GetAxis("Mouse Y") * ySensitivity;

		transform.localEulerAngles = new Vector3(yRotation, xRotation,0);
	}
}
