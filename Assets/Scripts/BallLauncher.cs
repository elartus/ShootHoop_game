using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallLauncher : MonoBehaviour {


    public GameObject ballPrefab;
    public float ballSpeed = 5.0f;
    
    void Start () {
		
	}
		
	void Update () {

        if (Input.GetButtonDown("Fire1")) {
            GameObject instance = Instantiate(ballPrefab);
            instance.transform.position = transform.position;
            Rigidbody rb = instance.GetComponent<Rigidbody>();
            rb.velocity = Vector3.forward * ballSpeed;
        }


    }
}
