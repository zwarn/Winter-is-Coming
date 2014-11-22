using UnityEngine;
using System.Collections;

public class Boulder : MonoBehaviour {

	float rotationSpeed = 1;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(new Vector3(0,0,rotationSpeed));
	}
}
