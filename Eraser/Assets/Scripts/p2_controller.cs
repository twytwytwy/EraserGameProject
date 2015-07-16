using UnityEngine;
using System.Collections;

public class p2_controller : MonoBehaviour {
	public eraser_model player;
	
	// Use this for initialization
	//	void Start () {
	//	
	//	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey ("i")) {
			player.force1 ();
		}
		if (Input.GetKey ("o")) {
			player.force2 ();
		}
		if (Input.GetKey ("k")) {
			player.force3 ();
		}
		if (Input.GetKey ("l")) {
			player.force4 ();
		}
	}
}
