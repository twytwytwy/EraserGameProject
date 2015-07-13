using UnityEngine;
using System.Collections;

public class Stamina : MonoBehaviour {

	public float max_Stamina = 100f;
	public float cur_Stamina = 0f;
	public float increaseRate = 0.2f;
	public float decreaseRate = 1f;
	public GameObject staminaBar;

	// Use this for initialization
	void Start () {
		cur_Stamina = max_Stamina;
	}
	
	// Update is called once per frame
	void Update () {
		// need to adjust to only react to key inputs for the respective players
		// Player 1: q w s a
		// Player 2: i o k l
		if (Input.anyKey == false) {
			increaseStamina ();
		} else {
			decreaseStamina ();
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
}
