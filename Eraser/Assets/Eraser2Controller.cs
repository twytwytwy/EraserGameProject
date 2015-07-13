using UnityEngine;
using System.Collections;

public class Eraser2Controller : MonoBehaviour {
	public float torqueX;
	public float torqueY;
	public float torqueZ;
	
	// Use this for initialization
	void Start () {
		Rigidbody eraser = GetComponent<Rigidbody> ();
		
		eraser.mass = 10;
		
		
	}
	
//	void ApplyForce(Rigidbody body) {
//		Vector3 direction = body.transform.position - transform.position;
//		body.AddForceAtPosition(direction.normalized, transform.position);
//	}
//	
//	// Update is called once per frame
//	void Update () {
//		Rigidbody eraser = GetComponent<Rigidbody> ();
//		if (Input.GetKey ("o")){
//			//float turn = Input.GetAxis("Horizontal");
//			torqueX += 5;
//		} else {
//			torqueX -= 5;
//		}
//	
//		if (Input.GetKey ("p")){
//			//float turn = Input.GetAxis("Horizontal");
//			torqueY += 5;
//		} else {
//			torqueY -= 5;
//		}
//
//		if (Input.GetKey ("l")){
//			//float turn = Input.GetAxis("Horizontal");
//			torqueZ += 5;
//		} else {
//			torqueZ -= 5;
//		}
//
//		if (Input.GetKey (";")){
//			//float turn = Input.GetAxis("Horizontal");
//			torqueX += 5;
//		} else {
//			torqueX -= 5;
//		}
//
//		if (torqueY < 0) {
//			torqueY = 0;
//		}
//		if (torqueZ < 0) {
//			torqueZ = 0;
//		}
//		if (torqueX < 0) {
//			torqueX = 0;
//		}
//		eraser.AddRelativeTorque(torqueX,torqueY,torqueZ);
//	}
	// Update is called once per frame
	void Update () {
		Rigidbody eraser = GetComponent<Rigidbody> ();
//		if (Input.GetKey("y")){
//			eraser.mass += 1;
//		}
//		if (Input.GetKey("u")){
//			eraser.mass -= 1;
//		}
		if (Input.GetKey ("o")){
			//float turn = Input.GetAxis("Horizontal");
			eraser.AddRelativeTorque(100,0,100);
		}
		
		if (Input.GetKey ("p")){
			//float turn = Input.GetAxis("Horizontal");
			eraser.AddRelativeTorque(-100,0,100);
		}
		if (Input.GetKey ("l")){
			//float turn = Input.GetAxis("Horizontal");
			eraser.AddRelativeTorque(100,0,-100);
		}
		if (Input.GetKey (";")){
			//float turn = Input.GetAxis("Horizontal");
			eraser.AddRelativeTorque(-100,0,-100);
		}
		
	}

}