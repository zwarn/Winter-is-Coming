using UnityEngine;
using System.Collections;

public class Boulder : MonoBehaviour {

	public float rotationSpeed = 1;

	public Vector3 direction = new Vector3(0,0,0);

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(new Vector3(0,0,rotationSpeed));

		transform.position += direction * Time.deltaTime;
	}
}
