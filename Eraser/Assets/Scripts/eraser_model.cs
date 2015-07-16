using UnityEngine;
using System.Collections;

public class eraser_model : MonoBehaviour {

	public stamina_model stamina;

//	// Use this for initialization
//	void Start () {
//	
//	}
//	
//	// Update is called once per frame
//	void Update () {
//	
//	}

	public void force1 () {
		if (stamina.canMove()) {
			GetComponent<Rigidbody> ().AddRelativeTorque (100, 0, 100);
			stamina.decrease();
		}
	}
	public void force2 () {
		if (stamina.canMove()) {
			GetComponent<Rigidbody> ().AddRelativeTorque (-100, 0, 100);
			stamina.decrease();
		}
	}
	public void force3 () {
		if (stamina.canMove()) {
			GetComponent<Rigidbody> ().AddRelativeTorque (100, 0, -100);
			stamina.decrease();
		}
	}
	public void force4 () {
		if (stamina.canMove()) {
			GetComponent<Rigidbody> ().AddRelativeTorque (-100, 0, -100);
			stamina.decrease();
		}
	}
}
