using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Falcon9move : MonoBehaviour
{
    public float speed = 1;

    public float start_time;

    private Rigidbody rigidbody;



    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();

        start_time = Time.time;
    }


    
    // Update is called once per frame
    void Update()
    {

        
        Vector3 movement = new Vector3(0, 5, 0);

        float current_time = Time.time;


        if((current_time - start_time) > 15)
            rigidbody.AddForce(movement * speed);
        
    }
}
