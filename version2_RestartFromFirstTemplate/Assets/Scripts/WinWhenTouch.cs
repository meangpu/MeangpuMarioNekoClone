using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinWhenTouch : MonoBehaviour
{
    GameManager gameMangerScpt;

    private void Start() 
    {
        gameMangerScpt = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
    }

    private void OnCollisionEnter2D(Collision2D other) 
    {
        if (other.gameObject.tag == "Player")
        {
            gameMangerScpt.WinLevel();
        }
    }
}
