using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlEnemy : MonoBehaviour
{
    Transform target;
    public float speed;


    void Start()
    {
        target = GameObject.FindWithTag("Player").transform;
    }


    void Update()
    {
        float step = speed * Time.deltaTime; // calculate distance to move
        transform.position = Vector3.MoveTowards(transform.position, target.position, step);
    }

}
