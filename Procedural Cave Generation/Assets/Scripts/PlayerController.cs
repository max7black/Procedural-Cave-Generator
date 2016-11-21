using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    private float bulletSpeed = 20;
    private float nextFire;

    public GameObject shot;
    public Transform shotSpawn;
    public float fireRate;

    Rigidbody rigidBody;
    Vector3 velocity;
    

	// Use this for initialization
	void Start () {
        rigidBody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        velocity = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical")).normalized * 10;

        if (Input.GetButton("Fire1") && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
            shot.GetComponent<Rigidbody>().velocity = shot.transform.forward * 6;
        }

    }

    void FixedUpdate()
    {
        rigidBody.MovePosition(rigidBody.position + velocity * Time.fixedDeltaTime);
        // make sure the y / height doesn't change
        //transform.position = new Vector3(transform.position.x, -1.5f, transform.position.z);
    }
}
