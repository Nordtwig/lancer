using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    //Set speed of rotation and movement
    [SerializeField] int movementSpeed; //A value around 3-10 is suitable
    [SerializeField] int turnSpeed; //A value around 200-500 is suitable
    [SerializeField] float angularSpeed; //A value between 0.6-0.8 is suitable

    Rigidbody rigidBody;

    // Use this for initialization
    void Start () {
        rigidBody = gameObject.GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        var x = Input.GetAxis("Horizontal") * Time.deltaTime * turnSpeed;
        var z = Input.GetAxis("Vertical") * Time.deltaTime * movementSpeed;
        transform.Rotate(0, x, 0);
        transform.Translate(0, 0, z);
    }
}
