using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

	public Vector2 direction;
	public float speed = 10;
	public float lifetime = 10;
	float deathTime;

	// Use this for initialization
	void Start () {
		deathTime = Time.time + lifetime;
	}
	
	// Update is called once per frame
	void Update () {
		transform.position += new Vector3(direction.x,direction.y,0) * Time.deltaTime * speed;

		Vector3 vectorToTarget = new Vector3 (direction.x, direction.y, 0);
		float angle = Mathf.Atan2(vectorToTarget.y, vectorToTarget.x) * Mathf.Rad2Deg;
		Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
		transform.rotation = Quaternion.Slerp(transform.rotation, q, Time.deltaTime * speed);

		if (Time.time > deathTime) {
			Destroy(gameObject);

		}
	}
}
