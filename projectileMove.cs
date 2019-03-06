using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectileMove : MonoBehaviour
{

    Rigidbody2D rb;
    public GameObject explosionPrefab;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        rb.AddForce(transform.right * 200f);
    }

    private void OnCollisionEnter2D(Collision2D collision){
        if(collision.gameObject.CompareTag("Asteroid")){
            // finds where to instantiate
            Vector2 instantiatePoint = collision.GetContact(0).point;
            // instantiate the explosion prefab
            Instantiate(explosionPrefab, instantiatePoint, Quaternion.identity);

            // Destroy asteroid
            Destroy(collision.gameObject);

            // destroy the missile (the gameObject that this script is attached to) (last thing to happen)
            Destroy(gameObject);
        }
    }
}
