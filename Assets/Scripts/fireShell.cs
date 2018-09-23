using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireShell : MonoBehaviour {

    public Rigidbody shellPrefab;
    public Transform barrelEnd;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
        if(Input.GetButtonDown("Fire1"))
        {
            Rigidbody shellInstance;
            shellInstance = Instantiate(shellPrefab, barrelEnd.position, barrelEnd.rotation) as Rigidbody;
            shellInstance.AddForce(barrelEnd.forward * 3000);
        }

	}
}
