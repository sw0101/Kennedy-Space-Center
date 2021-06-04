using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class Falcon9move : MonoBehaviour
{
    public float speed = 1;

    public float start_time;

    private Rigidbody rigidbody;

    // Particle systems
    public GameObject T1;
    public GameObject T2;
    public GameObject T3;
    public GameObject Steam;
    public GameObject Steam1;




    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        T1.SetActive(false); // Disabled Thrustor 1 Left (T1)
        T2.SetActive(false); // Disabled Thrustor 2 Middle (T2)
        T3.SetActive(false); // Disabled Thrustor 2 Middle (T2)

        



        start_time = Time.time;
    }


    
    // Update is called once per frame
    void Update()
    {

        
        Vector3 movement = new Vector3(0, 5, 0);

        float current_time = Time.time;

    // This begins the rocket "launch" sequence after 24 seconds (to match recording.)
    // Note: when game is started, all 3 thrustors are disabled. They are enabled once launch happens.
    
        if((current_time - start_time) > 24) {// This controls time
            rigidbody.AddForce(movement * speed); // This is the thing that actually moves the rocket (add force)
            Steam.SetActive(false); // Disables pre-launch element (Steam)
            Steam1.SetActive(false); // Disables pre-launch element (Steam1)
        }

        if((current_time - start_time) > 20) {// This controls time
            rigidbody.AddForce(movement * speed); // This is the thing that actually moves the rocket (add force)
            T1.SetActive(true); // Enables Thrustor 1 Left (T1)
            T2.SetActive(true); // Enables Thrustor 2 Middle (T2)
            T3.SetActive(true); // Enables Thrustor 2 Middle (T2)
        }
    }
}
