using UnityEngine;
using System.Collections;

public class EraserControllerClone : MonoBehaviour {
	public float torque;

	// Use this for initialization
	void Start () {
		Rigidbody eraser = GetComponent<Rigidbody> ();

		eraser.mass = 10;

	
	}
	

	// Update is called once per frame
	void Update () {
		Rigidbody eraser = GetComponent<Rigidbody> ();
//		if (Input.GetKey("y")){
//			eraser.mass += 1;
//		}
//		if (Input.GetKey("u")){
//			eraser.mass -= 1;
//		}
		if (Input.GetKey ("i")){
			//float turn = Input.GetAxis("Horizontal");
			eraser.AddRelativeTorque(100,0,100);
		}

		if (Input.GetKey ("o")){
			//float turn = Input.GetAxis("Horizontal");
			eraser.AddRelativeTorque(-100,0,100);
		}
		if (Input.GetKey ("k")){
			//float turn = Input.GetAxis("Horizontal");
			eraser.AddRelativeTorque(100,0,-100);
		}
		if (Input.GetKey ("l")){
			//float turn = Input.GetAxis("Horizontal");
			eraser.AddRelativeTorque(-100,0,-100);
		}
	
	}


}
