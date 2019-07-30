using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Destroy the spark object after 2 seconds

public class SparkController : MonoBehaviour
{
    private float lifeTime = 2f;

    // Update is called once per frame
    void Update()
    {
        if (lifeTime > 0)
        {
            lifeTime -= Time.deltaTime;
            if (lifeTime <= 0)
            {
                Destroy(this.gameObject);
            }
        }
    }

}
