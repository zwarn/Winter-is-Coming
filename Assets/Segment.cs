using UnityEngine;
using System.Collections;

public class Segment : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (transform.position.y < -30.5) {
			transform.Translate(new Vector3(0,61,0));
		}

	}
}
