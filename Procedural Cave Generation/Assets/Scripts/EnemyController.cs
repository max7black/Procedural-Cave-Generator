using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour {

    public int attack;
    public int health;
    public float speed;
    public int roamRadius;
    public int aggroRadius;
    public int attackRange;
    
    Vector3 desitnationPosition;
    Transform playerTrans;
    NavMeshAgent agent;

    // Use this for initialization
    void Start () {
        playerTrans = GameObject.FindGameObjectWithTag("Player").transform;
        agent = GetComponent<NavMeshAgent>();
    }
	
	// Update is called once per frame
	void Update () {
        // if Enemy is within the Aggro range of the player then it will start to move towards the player
        if (Aggro())
        {
            agent.destination = playerTrans.position;
        }
    }

    bool Aggro()
    {
        bool playerIsClose;
        float distanceFromPlayer = Vector3.Distance(transform.position, playerTrans.position);

        if (distanceFromPlayer < aggroRadius && distanceFromPlayer >= attackRange)
        {
            playerIsClose = true;
        }
        else
        {
            playerIsClose = false;
        }

        return playerIsClose;
    }

    void Shoot()
    {

    }
}
