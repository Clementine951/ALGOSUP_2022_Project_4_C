using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Pathfinding : MonoBehaviour
{
    public Transform[] goal;
    private NavMeshAgent agent;
    private int destPoint;
    public GameObject Character;
    public Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.destination = goal[0].position;
        anim.SetBool("Path", true);

    }
    // Update is called once per frame
    private void FixedUpdate()
    {
        if (!agent.pathPending && agent.remainingDistance < 1f)
        {
            GoToNextPoint();
        }
    }

    void GoToNextPoint()
    {
        if (goal.Length == 0)
        {
            return;
        }
        agent.destination = goal[destPoint].position;
        destPoint = Random.Range(0, 8);

    }
}
