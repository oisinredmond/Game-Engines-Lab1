using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Invoke("Remove", 5);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void Remove()
    {
        GameObject.Destroy(this.gameObject);
    }
}
