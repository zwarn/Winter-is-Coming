using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	public float worldSpeed = 1;
	public GameObject level;
	public GameObject bullet;
	public GameObject boulder;
	public GameObject player;
	public float cooldown = 1.6f;
	public float boulderCooldown = 5f;
	float difficulty = 0;
	public float timeToDifficulty = 30;
	float difficultyTime;
	float fireTime;
	float boulderTime;
	public bool pause = false;

	public AudioClip boulderSound;
	public AudioClip arrowSound;
	public AudioClip loseSound;

	// Use this for initialization
	void Start () {
		fireTime = Time.time + cooldown;
		boulderTime = Time.time + boulderCooldown;
		difficultyTime = Time.time + timeToDifficulty;
	}
	
	// Update is called once per frame
	void Update () {
		level.transform.Translate (0, -worldSpeed * Time.deltaTime, 0);

		if (Time.time > fireTime) {
			fireTime = Time.time + cooldown;

			Vector2 pos2D = Random.insideUnitCircle.normalized * 15;
			Vector3 pos3D = new Vector3 (pos2D.x, pos2D.y, 0);
			
			GameObject bulletObject = (GameObject) Instantiate (bullet, pos3D, Quaternion.identity);
			Bullet bulletComponent = bulletObject.GetComponent<Bullet> ();
			bulletComponent.direction.x = player.transform.position.x - pos3D.x;
			bulletComponent.direction.y = player.transform.position.y - pos3D.y;
			bulletComponent.direction.Normalize();
		}

		if (Time.time > boulderTime) {
			boulderTime = Time.time + boulderCooldown;

			Vector3 pos3D = new Vector3 (0, 20, 0);
			
			GameObject bulletObject = (GameObject) Instantiate (boulder, pos3D, Quaternion.identity);
			Boulder bulletComponent = bulletObject.GetComponent<Boulder> ();
			bulletComponent.direction.x = player.transform.position.x - pos3D.x;
			bulletComponent.direction.y = player.transform.position.y - pos3D.y;
			bulletComponent.direction.Normalize();

			AudioSource.PlayClipAtPoint(boulderSound,Camera.main.transform.position);
		}

		if (Time.time > difficultyTime) {
			difficultyTime = Time.time + timeToDifficulty;

			boulderTime -= 0.3f;
			fireTime -= 0.1f;
		}

	}
}