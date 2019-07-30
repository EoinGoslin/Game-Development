using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkForHits : MonoBehaviour
{
    public GameObject explosion;
    private void OnTriggerEnter(Collider other)
    {
        // If the bullet hits something destroy the bullet
        Destroy(other.gameObject);
        Instantiate(explosion, other.transform.position, other.transform.rotation);
    }

}
