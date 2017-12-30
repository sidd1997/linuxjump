using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movebackground : MonoBehaviour {
	public float speed =6; 
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		Vector2 mo = new Vector2(Time.time * speed,0) ;
		GetComponent<Renderer>().material.mainTextureOffset = mo/10;
	}
}
