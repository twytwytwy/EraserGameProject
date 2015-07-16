using UnityEngine;
using System.Collections;

public class P1_Control : MonoBehaviour {
//	public float torque;
//	public bool canMove = true;
//	public float max_Stamina = 100f;
//	public float cur_Stamina = 100f;
//	public float increaseRate = 0.5f;
//	public float decreaseRate = 1f;
//	public GameObject staminaBar;

	public eraser_model player;

	// Use this for initialization
	void Start () {
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKey ("q")){
			player.force1 ();
		}
		if (Input.GetKey ("w")){
			player.force2 ();
		}
		if (Input.GetKey ("a")) {
			player.force3 ();
		}
		if (Input.GetKey ("s")) {
			player.force4 ();
		}
}
	