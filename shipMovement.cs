using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class shipMovement : MonoBehaviour
{
    // rigidbody, so we can apply physics to GameObject
    Rigidbody2D rb;

    // amount of force to apply
    [SerializeField] private float movementForce;

    [SerializeField] private float hValue, vValue;

    // keep track of collected key
    [SerializeField] private bool hazKey = false;

    // Start is called before the first frame update
    void Start()
    {
        // get reference to rigidbody on gameObject
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        GetInput();
    }

    private void FixedUpdate()
    {
        // add a force to rigidbody (moves the ship horizontally and vertically)
        //rb.AddForce(new Vector2(hValue, vValue));
        //
        // moves ship toward/away the direction its facing
        rb.AddForce(transform.up * vValue);
    }

    void GetInput()
    {
        hValue = Input.GetAxis("Horizontal") * movementForce;
        vValue = Input.GetAxis("Vertical") * movementForce;
    }


}
