using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class points : MonoBehaviour {
    public float score;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "fireball")
        {
            IncreaseTextUIScore();
        }
    }
    void IncreaseTextUIScore()
    {
        var textui = GameObject.Find("Score").GetComponent<Text>();
        score = float.Parse(textui.text);
        score += 0.5f;
        textui.text = score.ToString();
    }
 

}
