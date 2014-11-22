using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float moveSpeed = 0.2f;
	public Rect bounds;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		float x = Input.GetAxis ("Horizontal") * moveSpeed;
		float y = Input.GetAxis ("Vertical") * moveSpeed;

		transform.Translate (new Vector3(x, y,0));

		float posX = transform.position.x;
		float posY = transform.position.y;

		if (posX < bounds.xMin) {
			posX = bounds.xMin;
		} else if (posX > bounds.xMax) {
			posX = bounds.xMax;
		}

		if (posY < bounds.yMin) {
			posY = bounds.yMin;
		} else if (posY > bounds.yMax) {
			posY = bounds.yMax;
		}

		transform.position = new Vector3 (posX, posY, 0);
	
	}

	void OnCollisionEnter2D (Collision2D collider) {
		Destroy (collider.gameObject);
	}
}
