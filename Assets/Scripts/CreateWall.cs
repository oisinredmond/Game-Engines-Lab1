using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateWall : MonoBehaviour {

	// Use this for initialization
	void Start () {

        int width = 10;
        int height = 10;
        float gap = 1.1f;

        for (int row = 0; row < height; row++)
        {
            for (int col = -width/2; col < width/2; col++)
            {
                GameObject wallBlock = GameObject.CreatePrimitive(PrimitiveType.Cube);
                wallBlock.AddComponent<Rigidbody>();
                float x = col * gap;
                float y = 0.5f + (row * gap);
                wallBlock.transform.rotation = Quaternion.identity;
                wallBlock.transform.position = transform.TransformPoint(new Vector3(x, y, 0));
                wallBlock.GetComponent<Renderer>().material.color = Color.HSVToRGB(Random.Range(0.0f, 1.0f), 1, 0.8f);
                wallBlock.transform.parent = this.transform;
            }
        }

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
