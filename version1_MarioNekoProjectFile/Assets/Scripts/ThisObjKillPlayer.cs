using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThisObjKillPlayer : MonoBehaviour
{

    [SerializeField] GameManager managerScpt;


    private void OnCollisionEnter2D(Collision2D other) 
    {
        if (other.gameObject.tag == "Player")
        {
            StartCoroutine(managerScpt.gameOver());
        }
    }



}
