using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{

    public float speed = 1f;
    public Rigidbody rb;
    public Vector3 movement;


    // Use this for initialization
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        movement = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")).normalized;
    }


    void FixedUpdate()
    {
        moveCharacter(movement);
    }


    void moveCharacter(Vector3 direction)
    {
        rb.velocity = direction * speed;
    }

}
