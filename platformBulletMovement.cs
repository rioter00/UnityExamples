using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformBulletMovement : MonoBehaviour
{
    public GameObject explosion;

    Rigidbody2D rb;

    [SerializeField] private float bulletSpeed;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = transform.right * bulletSpeed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Instantiate(explosion, gameObject.transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}

