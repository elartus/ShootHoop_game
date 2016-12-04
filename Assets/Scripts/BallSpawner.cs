using UnityEngine;
using System.Collections;

public class BallSpawner : MonoBehaviour {

    public GameObject ballPrefab;
    	
	void Start () {
                    
	
	}
		
	void Update () {

        float velocity = 5.0f;
       if (Input.GetKeyDown(KeyCode.LeftArrow)) {
            GameObject instance = Instantiate(ballPrefab);
            Rigidbody rb =  instance.GetComponent<Rigidbody>();
            rb.velocity = Vector3.left * velocity;
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            GameObject instance = Instantiate(ballPrefab);
            Rigidbody rb = instance.GetComponent<Rigidbody>();
            rb.velocity = Vector3.right * velocity;
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            GameObject instance = Instantiate(ballPrefab);
            Rigidbody rb = instance.GetComponent<Rigidbody>();
            rb.velocity = Vector3.forward * velocity;
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            GameObject instance = Instantiate(ballPrefab);
            Rigidbody rb = instance.GetComponent<Rigidbody>();
            rb.velocity = Vector3.back * velocity;
        }

    }
}
