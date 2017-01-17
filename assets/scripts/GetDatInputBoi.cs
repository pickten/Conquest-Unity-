using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetDatInputBoi : MonoBehaviour {
    public int state;
    public int RHexX;
    public int RHexY;
    public int MinX;
    public int MaxX;
    public int MinY;
    public int MaxY;
    public GameObject GHex;
    public GameObject RHex;
    public GameObject AyyLmao;
    void Start() {
	state = 0;
	GHex = GameObject.Find("GHex");
	RHex = GameObject.Find("RHex");
	AyyLmao = GameObject.Find("ayy lmao");
	RHexX = Random.Range(-70, 70);
	RHexY = Random.Range(-30, 30);
	MinX = RHexX - 5;
	MaxX = RHexX + 5;
	MinY = RHexY - 5;
	MaxY = RHexY + 5;
	RHex.transform.position = new Vector2 (RHexX, RHexY);
    }
    void Update() {
	if (Input.GetKey("w")) {
	    GHex.transform.Translate(Vector2.up);
	}
	if (Input.GetKey("s")) {
	    GHex.transform.Translate(Vector2.down);
	}
	if (Input.GetKey("a")) {
	    GHex.transform.Translate(Vector2.left);
	}
	if (Input.GetKey("d")) {
	    GHex.transform.Translate(Vector2.right);
	}
	if (Input.GetKey("space")) {
	    GHex.transform.position = new Vector3 (0, 0, -1);
	}
	if (((GHex.transform.position.x >= MinX) && (GHex.transform.position.x <= MaxX)) &&
	    ((GHex.transform.position.y >= MinY) && (GHex.transform.position.y <= MaxY))) {
	    switch (state) {
		case 0:
		    AyyLmao.transform.Translate(Vector2.up);
		    state = 1;
		    break;
		case 1:
		    AyyLmao.transform.Translate(Vector2.right);
		    state = 2;
		    break;
		case 2:
		    AyyLmao.transform.Translate(Vector2.down);
		    state = 3;
		    break;
		case 3:
		    AyyLmao.transform.Translate(Vector2.left);
		    state = 0;
		    break;
	    }
	}
    }
}
