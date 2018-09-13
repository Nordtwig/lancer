using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    //Set speed of rotation and movement
    [SerializeField] int movementSpeed; //A value around 3-10 is suitable
    [SerializeField] int turnSpeed; //A value around 200-500 is suitable

    [SerializeField] bool isPlayer2 = false;

    Rigidbody rigidBody;

    // Use this for initialization
    void Start () {
        rigidBody = gameObject.GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        if (!isPlayer2)
        {
            var x = Input.GetAxis("Horizontal") * Time.deltaTime * turnSpeed;
            var z = Input.GetAxis("Vertical") * Time.deltaTime * movementSpeed;
            if (z < 0)
            {
                z = z / 2;
            }
            transform.Rotate(0, x, 0);
            transform.Translate(0, 0, z);
        }
        else
        {
            var x = Input.GetAxis("Horizontal2") * Time.deltaTime * turnSpeed;
            var z = Input.GetAxis("Vertical2") * Time.deltaTime * movementSpeed;
            if (z < 0)
            {
                z = z / 2;
            }
            transform.Rotate(0, x, 0);
            transform.Translate(0, 0, z);
        }
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Lance")
        {
            print("Hit!");
        }
    }
}
