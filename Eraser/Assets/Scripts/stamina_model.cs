using UnityEngine;
using System.Collections;

public class stamina_model : MonoBehaviour {

	public bool can_move = true ;
	public float max_stamina = 100f;
	public float cur_stamina = 100f;
	public float increase_rate = 0.5f;
	public float decrease_rate = 1f;

	private Transform bar_transf;

	// Use this for initialization
	void Start () {
		bar_transf = GetComponent<Transform> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (cur_stamina < 5) {
			can_move = false;
		} else {
			can_move = true;
		}
		increase ();
		setStaminaBar ();
	}

	public void increase() {
		if (cur_stamina < max_stamina) {
			cur_stamina += increase_rate;
		}
	}
	
	public void decrease() {
		if (cur_stamina > 0f) {
			cur_stamina -= decrease_rate;
		}
	}

	public void setStaminaBar() {
		float ratio = cur_stamina / max_stamina; 
		bar_transf.localScale = new Vector3 (Mathf.Clamp(ratio, 0f, 1f), bar_transf.localScale.y, bar_transf.localScale.z);
	}

	public bool canMove () {
		return can_move;
	}
}
