using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SportyGirlController : MonoBehaviour
{
	
	public Vector3 position;

    // Start is called before the first frame update
    void Start()
   {
    Transform startPosition = this.gameObject.GetComponent<Transform> ();
	startPosition.transform.position = new Vector3(21.3f, 0.3f, 0.0f);
   }

   void Update () 
   {
	float moveHorizontal = Input.GetAxis ("Horizontal");
	float moveVertical = Input.GetAxis ("Vertical");
	NavMeshAgent agent = GetComponent<NavMeshAgent>();

	//キャラを回転させる
	transform.Rotate(new Vector3(0.0f, moveHorizontal, 0.0f));

	position += transform.forward * moveVertical * 0.02f;
	//agent.nextPosition = position;
	}
}
