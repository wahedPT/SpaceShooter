using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawn : MonoBehaviour
{
    public GameObject Bulletobj; 
    public float Bulletspeed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
          
            GameObject bulletref = Instantiate(Bulletobj);
            bulletref.transform.position = transform.position;
            Rigidbody2D rb = bulletref.GetComponent<Rigidbody2D>();
            rb.velocity = Vector2.up * Bulletspeed;
        }
    }

}
