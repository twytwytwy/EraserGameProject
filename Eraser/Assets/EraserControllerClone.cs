using UnityEngine;
using System.Collections;

public class EraserControllerClone : MonoBehaviour {
	public float torque;
	public bool canMove;
	public float max_Stamina = 100f;
	public float cur_Stamina = 100f;
	public float increaseRate = 0.5f;
	public float decreaseRate = 1f;
	public GameObject staminaBar;
	
	// Use this for initialization
	void Start () {
		Rigidbody eraser = GetComponent<Rigidbody> ();
		eraser.mass = 10;
		canMove = true;
	}
	
	// Update is called once per frame
	void Update () {
		Rigidbody eraser = GetComponent<Rigidbody> ();
		/*
		GameObject g = GameObject.Find ("staminaBar");
		
		Stamina stamina = g.GetComponent<Stamina> ();
		*/
		// Check if current stamina is at 0
		if (getStamina() < 5) {
			canMove = false;
		} else {
			canMove = true;
		}
		
		if (Input.GetKey ("y")) {
			eraser.mass += 1;
		}
		if (Input.GetKey ("u")) {
			eraser.mass -= 1;
		}
		if ((Input.GetKey ("i")) && (canMove == true)){
			//float turn = Input.GetAxis("Horizontal");
			eraser.AddRelativeTorque (100, 0, 100);
			decreaseStamina ();
		}
		if ((Input.GetKey ("o")) && (canMove == true)){
			//float turn = Input.GetAxis("Horizontal");
			eraser.AddRelativeTorque (-100, 0, 100);
			decreaseStamina ();
		}
		if ((Input.GetKey ("k")) && (canMove == true)){
			//float turn = Input.GetAxis("Horizontal");
			eraser.AddRelativeTorque (100, 0, -100);
			decreaseStamina ();
		}
		if ((Input.GetKey ("l")) && (canMove == true)){
			//float turn = Input.GetAxis("Horizontal");
			eraser.AddRelativeTorque (-100, 0, -100);
			decreaseStamina ();
		} else {
			increaseStamina ();
		}
	}
	void increaseStamina() {
		if (cur_Stamina < max_Stamina) {
			cur_Stamina += increaseRate;
			float stamina = cur_Stamina / max_Stamina;
			setStaminaBar (stamina);
		}
	}
	
	void decreaseStamina() {
		if (cur_Stamina > 0f) {
			cur_Stamina -= decreaseRate;
			float stamina = cur_Stamina / max_Stamina;
			setStaminaBar (stamina);
		}
	}
	public void setStaminaBar(float stam) {
		// 0 < stam < 1
		staminaBar.transform.localScale = new Vector3 (Mathf.Clamp(stam, 0f, 1f), staminaBar.transform.localScale.y, staminaBar.transform.localScale.z);
	}
	public float getStamina()
	{
		return cur_Stamina;
	}
}
