using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankController : MonoBehaviour {

    public float speed;
    public float turnSpeed;
    public Rigidbody WallBlock;

    private Rigidbody rb;
    private float moveForwardBack;
    private float rotationY;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        float moveForwardBack = Input.GetAxis("Vertical") * speed;
        float rotationY = Input.GetAxis("Horizontal") * turnSpeed;

        Vector3 movement = transform.forward * moveForwardBack * Time.deltaTime;

        transform.Rotate(0, rotationY, 0);
        rb.MovePosition(rb.position + movement);
	}
}
