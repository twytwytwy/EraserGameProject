using UnityEngine;
using System.Collections;

public class rotate : MonoBehaviour {
	public int speed = 10;

	// Use this for initialization
	void Start () {
	}

	// Update is called once per frame
	void Update () {
		transform.Rotate (Vector3.up, Time.deltaTime * speed);
	}
}
