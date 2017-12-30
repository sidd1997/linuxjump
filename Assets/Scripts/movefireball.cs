using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movefireball : MonoBehaviour {
	public float speed = 0.5f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Time.timeScale == 1)
        {
            transform.Translate(new Vector3(-1, 0, 0) * speed);
        }
		
		
	}
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "leftwall")
        {
            Destroy(gameObject);
        }
    }
 
}
