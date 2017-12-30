using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireball : MonoBehaviour {
    public GameObject fball;
	public GameObject topfball;
    public float speed = 0.5f;
	public float delaytime = 3f;
	float times;
	float twotime;
	// Use this for initialization
	void Start () {
		times = delaytime+1;
		twotime = delaytime +2;
	}
	
	// Update is called once per frame
	void Update () {
		twotime -= Time.deltaTime;
		if (twotime <0 ) {
			Vector3 poss = new Vector3 (transform.position.x, 16f, transform.position.z);
			Instantiate(topfball, poss, transform.rotation);
			twotime = delaytime +1 ;
		}
		times -= Time.deltaTime;
		if (times < 0) {
			Vector3 poss = new Vector3 (transform.position.x, -25f, transform.position.z);
			Instantiate (fball, poss, transform.rotation);
			times = delaytime+1;

		}

	}
}
