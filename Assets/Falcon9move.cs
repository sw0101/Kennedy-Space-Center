using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Falcon9move : MonoBehaviour
{
    public float speed = 1;

    private Rigidbody rigidbody;

    private float movementX;
    private float movementY;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }


    
    // Update is called once per frame
    void Update()
    {

        System.Diagnostics.Debug.WriteLine("Log before movement");
        Vector3 movement = new Vector3(0, 5, 0);

        rigidbody.AddForce(movement * speed);
        System.Diagnostics.Debug.WriteLine("Log after movement");
    }
}
