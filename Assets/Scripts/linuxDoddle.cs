using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class linuxDoddle : MonoBehaviour {
    float times;
    float delay=0.2f;
	public Rigidbody2D rb;
	public float speed = 10;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D>();
        times = delay;
	}

	// Update is called once per frame
	void Update () {
		transform.Rotate(0, 0, speed * Time.deltaTime);
        times -= Time.deltaTime;
        if (times < 0)
        {
            Vector2 jum = new Vector2(0, -1);

            rb.velocity = jum * 15;
            times = delay;
        }
       
    }
	private void FixedUpdate()
	{
		if (Input.GetMouseButtonDown(0))
		{
			Vector2 jum = new Vector2(0, 1);

			rb.velocity = jum * 30;
		}
	}
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "fireball")
        {
            Time.timeScale = 0;
            SceneManager.LoadScene("gameover");
        }
        if (collision.gameObject.name == "bottomwall")
        {
            Time.timeScale = 0;
            SceneManager.LoadScene("gameover");
        }
    }


}
