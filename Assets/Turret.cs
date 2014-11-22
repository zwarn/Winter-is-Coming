using UnityEngine;
using System.Collections;

public class Turret : MonoBehaviour {

	public float cooldown = 3;
	float shootingTime;
	public GameObject bullet;
	public GameObject target;

	// Use this for initialization
	void Start () {
		shootingTime = Time.time + cooldown;
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time > shootingTime) {
			shootingTime = Time.time + cooldown;
			Instantiate (bullet, transform.position, transform.rotation);
		}
	}
}
