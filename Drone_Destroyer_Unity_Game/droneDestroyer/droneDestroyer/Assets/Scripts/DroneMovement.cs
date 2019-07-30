using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroneMovement : MonoBehaviour
{
   
    public float acceleration;
    public float max_speed;
    public float min_speed;
    public float tiltSpeed;
    public float turnSpeed;

    // The numbers .258 and .382 are used as in the inspector they correspond to 30 and 45 degrees
    // So can not tilt or rotate the player past these angles

    private void FixedUpdate()
    {

        if (Input.GetKey(KeyCode.W))
        {
            // If W and S pressed, still accelerate
            accelerate();
            if(Input.GetKey(KeyCode.S)) {
                accelerate();
            }
        }


        // slow the player down
        if (Input.GetKey(KeyCode.S)) 
        {
            decelerate();
        }


        // maintain speed
        if (!Input.GetKey(KeyCode.W)) {

            transform.Translate(transform.forward * (acceleration * acceleration) * Time.deltaTime, Space.World);
        }


        // Rotate Drone
        if (Input.GetKey(KeyCode.D))
        {
            //Rotate the current game object, using deltaTime for consistency across machines.
            transform.Rotate(transform.up, turnSpeed * Time.deltaTime, Space.World);
        }

        if (Input.GetKey(KeyCode.A))
        {
            //Rotate the current game object's transform, using deltaTim for consistency across machines.
            transform.Rotate(transform.up, -turnSpeed * Time.deltaTime, Space.World);
        }

        // Tilt drone left
        if (Input.GetKey(KeyCode.LeftArrow)) {
            if (transform.rotation.z < 0.258) {
                transform.Rotate(0, 0, tiltSpeed * Time.deltaTime);

            }
           
        }
        // Tilt drone right
        if (Input.GetKey(KeyCode.RightArrow)) {
            if (transform.rotation.z > -0.258)
            {
                transform.Rotate(0, 0, -tiltSpeed * Time.deltaTime);

            }
        }

        // Tilt Up
        if (Input.GetKey(KeyCode.UpArrow))
        {
            if (transform.rotation.x > -0.382) {
                transform.Rotate(-tiltSpeed * Time.deltaTime, 0, 0);

            }
        }


        // Lift Down
        if (Input.GetKey(KeyCode.DownArrow))
        {
            if (transform.rotation.x < 0.382)
            {
                transform.Rotate(tiltSpeed * Time.deltaTime, 0, 0);

            }
        }
    }

    // When W is pressed
    private void accelerate() {

        if (acceleration < max_speed)
        {
            acceleration += 0.2f;
        }
        else
        {
            acceleration = max_speed;
        }

        transform.Translate(transform.forward * (acceleration * acceleration) * Time.deltaTime, Space.World);
    }
    // When S is pressed
    private void decelerate() {
        if (acceleration > 0)
        {
            acceleration -= 0.2f;
        }
        else
        {
            acceleration = min_speed;
        }
    }


}
