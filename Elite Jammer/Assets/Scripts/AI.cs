using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI : MonoBehaviour
{
    public float lookDistance;
    private bool seePlayer;
    private Transform target;
    private UnityEngine.AI.NavMeshAgent agent;
    // public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        target = PlayerLocation.instance.player.transform;
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(target.position, transform.position);
        if (distance <= lookDistance)
        {
            agent.SetDestination(target.position);
            seePlayer = true;
        }
        else
        {
            seePlayer = false;
        }
        // animator.SetBool("Chase", seePlayer);
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireCube(transform.position, new Vector3( lookDistance, 2, 2));
    }
}
