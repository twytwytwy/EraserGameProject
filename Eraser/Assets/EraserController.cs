using UnityEngine;
using System.Collections;

public class EraserController : MonoBehaviour {
	public float torque;

	// Use this for initialization
	void Start () {
		Rigidbody eraser = GetComponent<Rigidbody> ();

		eraser.mass = 10;

	
	}
	

	// Update is called once per frame
	void Update () {
		Rigidbody eraser = GetComponent<Rigidbody> ();
		if (Input.GetKey("y")){
			eraser.mass += 1;
		}
		if (Input.GetKey("u")){
			eraser.mass -= 1;
		}
		if (Input.GetKey ("q")){
			//float turn = Input.GetAxis("Horizontal");
			eraser.AddRelativeTorque(100,0,100);
		}

		if (Input.GetKey ("w")){
			//float turn = Input.GetAxis("Horizontal");
			eraser.AddRelativeTorque(-100,0,100);
		}
		if (Input.GetKey ("a")){
			//float turn = Input.GetAxis("Horizontal");
			eraser.AddRelativeTorque(100,0,-100);
		}
		if (Input.GetKey ("s")){
			//float turn = Input.GetAxis("Horizontal");
			eraser.AddRelativeTorque(-100,0,-100);
		}
	
	}


}
