using UnityEngine;
using System.Collections;

public class Segment : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (transform.position.y < -20) {
			transform.Translate(new Vector3(0,50,0));
		}

	}
}
