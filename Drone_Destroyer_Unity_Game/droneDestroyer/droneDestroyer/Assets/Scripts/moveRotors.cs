using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Rotor1 and Rotor4, only two seen
public class moveRotors : MonoBehaviour
{
    // Moves the player's rotor at different speeds depending on how fast the player is moving
    public float lowRotationSpeed;
    public float midRotationSpeed;
    public float topRotationSpeed;
    
    private GameObject[] rotors;
    private DroneMovement droneMovement;
    private GameObject drone;
    float x;

    // Start is called before the first frame update
    void Start()
    {
        // This returns the GameObject
        rotors = GameObject.FindGameObjectsWithTag("Rotor");

        drone = GameObject.FindWithTag("Player");
        droneMovement = drone.GetComponent<DroneMovement>();


    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // rotors go slower wheh moving slower

        if (droneMovement.acceleration <= 5) {
            x += lowRotationSpeed;
        } else if (droneMovement.acceleration >= 5 && droneMovement.acceleration <= 10) {
            x += midRotationSpeed;
        } else {
            x += topRotationSpeed;
        }

        turnRotors(rotors, x);

    }
    // the z axis value is different depending on how fast the player is moving
    private void turnRotors(GameObject[] rotors, float x) {
        for (int i = 0; i < rotors.Length; i++) {
            rotors[i].transform.rotation = Quaternion.Euler(-91f, 0, x);
        } 

    }





}

