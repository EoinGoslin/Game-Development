using UnityEngine;

public class EnemyBullet : MonoBehaviour
{

    public Vector3 travelDirection;
    public float speed;
    public float gravity;
    public float lifeTime;
    public Vector3 targetPosition;
    private Vector3 moveDir;

    private GameObject player;


    private Rigidbody rb;


    private void Start()
    {

        player = GameObject.FindWithTag("Player");
        rb = GetComponent<Rigidbody>();

    }

    // Logic same as player bullet - time used instead of frame count for bullet life

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
        // So bullet dips with gravity
        var firingVector = transform.forward;
        var axis = Vector3.Cross(firingVector, Vector3.down);
        firingVector = Quaternion.AngleAxis(gravity, axis) * firingVector;
        rb.velocity = firingVector * speed;
    }



}       
