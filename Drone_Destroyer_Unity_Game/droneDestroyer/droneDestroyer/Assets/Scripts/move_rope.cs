using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Workaround to animate rope as it is flying through the air
// Moves rope by its transform axis


public class move_rope : MonoBehaviour
{

    private bool flag = true;
    private float timeLeft = 0.2f;
    // Update is called once per frame
    void Update()
    {
        timeLeft -= Time.deltaTime;
        if (timeLeft < 0)
        {

            timeLeft = 0.2f;
            if (flag)
            {
                transform.Rotate(2, 0, 0);
                flag = false;
            }
            else
            {
                transform.Rotate(-2, 0, 0);
                flag = true;
            }
        }
       
    }

    private void OnCollisionEnter(Collision collision)
    {
        print("oop");
    }

}
