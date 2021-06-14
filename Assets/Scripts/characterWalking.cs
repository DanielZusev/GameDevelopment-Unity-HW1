using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class characterWalking : MonoBehaviour
{
    private NavMeshAgent agent;
    public GameObject player;
    private Animator anim;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(player.transform.position);
        anim.SetBool("isWalking", true);
    }
}
