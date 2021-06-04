using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyMovement : MonoBehaviour
{
    AudioSource PlayerDestroy;
    Rigidbody2D rb;
    public void GoToNextScene()
    {
        Destroys();
    }

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        PlayerDestroy = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(0, -1); 
    }
    private void OnBecameInvisible()
    {
        Destroy(this.gameObject);

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="Spaceship")
        {
            Destroy(collision.gameObject);
            PlayerDestroy.Play();
            Destroys();


        }
    }

    private void Destroys()
    {
       
        SceneManager.LoadScene(2);
    }
}
