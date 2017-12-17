using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LooseCollider : MonoBehaviour {

	void OnTriggerEnter2D (Collider2D trigger) {
		print("trigger");
	}

	void OnCollisionEnter2D (Collision2D collision) {
		print("Collision");
	}


}
