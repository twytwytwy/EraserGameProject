using UnityEngine;
using System.Collections;

public class rotate : MonoBehaviour {

	public GameObject platform;
	private Transform platform_tranf;

	public int speed = 10;

	// Use this for initialization
	void Start () {
		platform_tranf = platform.GetComponent<Transform> ();
	}

	// Update is called once per frame
	void Update () {
		platform_tranf.Rotate (Vector3.up, Time.deltaTime * speed);
	}
}
