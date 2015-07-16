using UnityEngine;
using System.Collections;

public class p1_controller : MonoBehaviour {

	public eraser_model player;

	// Use this for initialization
//	void Start () {
//	
//	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey ("q")) {
			player.force1 ();
		}
		if (Input.GetKey ("w")) {
			player.force2 ();
		}
		if (Input.GetKey ("a")) {
			player.force3 ();
		}
		if (Input.GetKey ("s")) {
			player.force4 ();
		}
	}
}
