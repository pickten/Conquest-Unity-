using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetDatInputBoi : MonoBehaviour {
    void Update() {
	if (Input.GetKey("w")) {
	    transform.Translate(Vector2.up);
	}
	if (Input.GetKey("s")) {
	    transform.Translate(Vector2.down);
	}
	if (Input.GetKey("a")) {
	    transform.Translate(Vector2.left);
	}
	if (Input.GetKey("d")) {
	    transform.Translate(Vector2.right);
	}
	if (Input.GetKey("space")) {
	    transform.position = new Vector2 (0, 0);
	}
    }
}
