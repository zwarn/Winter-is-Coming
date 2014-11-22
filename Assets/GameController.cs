using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	public float worldSpeed = 1;
	public GameObject level;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		level.transform.Translate (0, -worldSpeed * Time.deltaTime, 0);
	}
}
