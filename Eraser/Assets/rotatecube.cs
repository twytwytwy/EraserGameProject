using UnityEngine;
using System.Collections;

public class rotatecube : MonoBehaviour {
	public int speed = 10;
	public int change_dir = 1000;
	int counter = 0;
	int dir = 0;
	Vector3 move = Vector3.right;
	public float scale = 0.008f;
	Vector3 scaler;
	Vector3 dir_;

	// Use this for initialization
	void Start () {
		scaler.Set (scale, scale, scale);
	}

	// Update is called once per frame
	void Update () {
		transform.Rotate (move, Time.deltaTime * speed);
		counter++;
		if (counter > change_dir) {
			counter = 0;
			dir = (dir + 1) % 7;
		}
		switch (dir){
		case 0:
			dir_ = Vector3.right;
			break;
		case 1:
			dir_ = Vector3.forward;
			break;
		case 2:
			dir_= Vector3.left;
			break;
		case 3:
			dir_ = Vector3.back;
			break;
		case 4:
			dir_ = Vector3.up;
			break;
		case 5:
			dir_= Vector3.right;
			break;
		case 6:
			dir_ = Vector3.down;
			break;
		}
		dir_.Scale (scaler);
		move = move + dir_;
		move = move.normalized;


	}
}
