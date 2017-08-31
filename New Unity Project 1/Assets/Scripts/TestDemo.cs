using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestDemo : MonoBehaviour {

	// Use this for initialization
	void Start () {
        gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(300, -100, 0));
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
