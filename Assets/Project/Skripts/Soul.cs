using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Soul : MonoBehaviour
{
    public NavMeshAgent agent;
    void Start()
    {
        agent.destination = Portal.rid.transform.position;
    }
}
