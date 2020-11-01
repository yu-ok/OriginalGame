using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    public GameObject target;
    private NavMeshAgent agent;
    private bool isEnd = false;
    
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();

    }
 
    void Update()
    {
        agent.destination = target.transform.position;

        if(isEnd == true)
		{
			agent.enabled = false;
		}

    }

}
