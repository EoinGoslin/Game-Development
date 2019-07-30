using UnityEngine;

public class Bullet : MonoBehaviour
{

    public Vector3 travelDirection;
    public float speed;
    public float gravity;
    public float lifeTime;
    public Vector3 targetPosition;


    private Rigidbody rb;

    
    private void Start()
    {
        // Get the rigid body so can access it's velocity
        rb = GetComponent<Rigidbody>();


    }

    // Timer is used in update which runs every frame
    // Time.delta is used so time of bullet depends on seconds not actual frame count
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
        // Make the bullet start to dip as it is travelling
        var firingVector = transform.forward;
        var axis = Vector3.Cross(firingVector, Vector3.down);
        firingVector = Quaternion.AngleAxis(gravity, axis) * firingVector;
        rb.velocity = firingVector * speed;
       

    }

   






}
