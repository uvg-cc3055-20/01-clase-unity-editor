using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Truck : MonoBehaviour {

    Rigidbody2D rb;
    public float jumpForce = 100;
    public float speed = 10;
    public float tireSpeed = 50;
    public GameObject tire1;
    public GameObject tire2;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Jump")) {
            rb.AddForce(Vector2.up * jumpForce);
        }

        float horizontal = Input.GetAxis("Horizontal");
        rb.AddForce(Vector2.right*speed * horizontal);

        if (horizontal != 0) {
            tire1.transform.Rotate(new Vector3(0, 0, 1) * tireSpeed * Time.deltaTime * horizontal * -1);
            tire2.transform.Rotate(new Vector3(0, 0, 1) * tireSpeed * Time.deltaTime * horizontal * -1);
        }

	}
}
