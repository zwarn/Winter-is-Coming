using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	public float worldSpeed = 1;
	public GameObject level;
	public GameObject bullet;
	public GameObject player;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		level.transform.Translate (0, -worldSpeed * Time.deltaTime, 0);

		Vector2 pos2D = Random.insideUnitCircle;
		Vector3 pos3D = new Vector3 (pos2D.x, pos2D.y, 0);

		Instantiate (bullet, pos3D, Quaternion.identity);
	}
}
