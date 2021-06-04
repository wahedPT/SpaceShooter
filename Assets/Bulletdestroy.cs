using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bulletdestroy : MonoBehaviour
{
  AudioSource enemydestroy;
    //public int Score = 0;



    private void Start()
    {
        enemydestroy = GetComponent<AudioSource>(); 
    }

    private void OnBecameInvisible()
    {
        Destroy(this.gameObject);
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(collision.gameObject);
            enemydestroy.Play();
                

            //Score++;
            //print("the score is:" + Score);

            // Destroy(this.gameObject);

        }
    }
}
