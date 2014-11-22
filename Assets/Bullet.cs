using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

	public Vector2 direction;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		transform.Translate (new Vector3(direction.x,direction.y,0) * Time.deltaTime);

	}
}
