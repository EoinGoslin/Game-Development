using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_rotors : MonoBehaviour
{

    public float midRotationSpeed;


    private GameObject[] rotors;
    float x;

    // Update is called once per frame
    void FixedUpdate()
    {
        // need to keep checking as enemies get destroyed
        rotors = GameObject.FindGameObjectsWithTag("enemy_Rotor");
        x += midRotationSpeed;
        turnRotors(rotors, x);

    }
    // For all the rotors of each object, move them so they are rotating as the enemy moves
    private void turnRotors(GameObject[] rotors, float x)
    {
        if (this.gameObject != null)
        {

            for (int i = 0; i < rotors.Length; i++)
            {
            rotors[i].transform.rotation = Quaternion.Euler(-91f, 0, x);   
            }
        }

    }

}
