using UnityEngine;
using System.Collections;

public class CameraRotation : MonoBehaviour {

	// Use this for initialization
	void Start () {
<<<<<<< HEAD
        print("Parent Transform");
        print(transform);
        print("Camera Transform");
        Camera camera = GetComponentInChildren<Camera>();
        print(camera.transform);
        	
=======
		print ("Parent Transform");
		print (transform);
		print ("Children transform");

>>>>>>> b347f48d663358e919e5b3274f51d1d3d3b422c0
	}
	
	// Update is called once per frame
	void Update () {

        float rotationSpeed = 5.0f;
        float mouseX = Input.GetAxis("Mouse X") * rotationSpeed;
        float mouseY = Input.GetAxis("Mouse Y") * rotationSpeed;

<<<<<<< HEAD
        transform.rotation = Quaternion.Euler(mouseY, mouseX, 0) * transform.rotation;
=======
        transform.localRotation = Quaternion.Euler(0, mouseX, 0) * transform.localRotation;
		Camera camera = GetComponentInChildren<Camera>();
		camera.transform.localRotation = Quaternion.Euler (mouseY, 0, 0) * camera.transform.localRotation;
>>>>>>> b347f48d663358e919e5b3274f51d1d3d3b422c0
             
    }
}
