using UnityEngine;
using System.Collections;

public class MoveDrone : MonoBehaviour
{
    public float moveSpeed = 500f;
    public float rotationSpeed = 2.0f;
    public bool isGrounded = false;
    public float minDist = 4.0f;
    public float maxDist = 1000f;

    private float minSqrDist;
    private float maxSqrDist;

    private Transform myTransform;
    private Transform target;

    private Rigidbody myRigidbody;
    private Vector3 desiredVelocity;


    void Start()
    {
        minSqrDist = minDist * minDist;
        maxSqrDist = maxDist * maxDist;

        myTransform = transform;
        myRigidbody = GetComponent<Rigidbody>();

        GameObject go = GameObject.FindGameObjectWithTag("Player");
        target = go.transform;

    }

    void Update()
    {
        float sqrDist = (target.position - myTransform.position).sqrMagnitude;

        Quaternion calcRot = Quaternion.LookRotation(target.position - myTransform.position);

        desiredVelocity = new Vector3(0, myRigidbody.velocity.y, 0);

        // apply rotation
        myTransform.rotation = Quaternion.Slerp(myTransform.rotation, calcRot, rotationSpeed * Time.deltaTime);

        // modify desiredVelocity if within range
        if (sqrDist > minSqrDist && sqrDist < maxSqrDist)
        {
            desiredVelocity = myTransform.forward * moveSpeed;
            desiredVelocity.y = myRigidbody.velocity.y;
        }

    }

    void FixedUpdate()
    {
        if (isGrounded)
        {
            myRigidbody.velocity = desiredVelocity;
        }
    }

    // Bottom methods are so that the drones do not pile on top of each other
    // Code from Unity answer https://answers.unity.com/questions/406685/my-enemies-merge-when-they-come-towards-me.html
    void OnCollisionEnter(Collision other)
    {
          

        if (other.collider.gameObject.tag == "terrain")
        {
            isGrounded = true;
        }
    }

    void OnCollisionStay(Collision other)
    {
          

        if (other.collider.gameObject.tag == "terrain")
        {
            isGrounded = true;
        }
    }

    void OnCollisionExit(Collision other)
    {
          

        if (other.collider.gameObject.tag == "terrain")
        {
            isGrounded = false;
        }
    }


}
