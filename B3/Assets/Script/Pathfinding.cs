using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Pathfinding : MonoBehaviour
{
    public Transform goal;
    public GameObject Character;
    public Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        NavMeshAgent agent = GetComponent<NavMeshAgent>();
        agent.destination = goal.position;
        anim.SetBool("Path", true);
        
    }
    // Update is called once per frame
    private void Update()
    {
        if (Character.transform.position.y == goal.position.x || Character.transform.position.z == goal.position.z)
            anim.SetBool("Path", false);
    }
}
