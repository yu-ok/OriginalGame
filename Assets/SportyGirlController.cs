using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SportyGirlController : MonoBehaviour
{
	
    // Start is called before the first frame update
    void Start()
    {
		
    }

   void Update () 
   {
	float moveHorizontal = Input.GetAxis ("Horizontal");
	float moveVertical = Input.GetAxis ("Vertical");
	NavMeshAgent agent = GetComponent<NavMeshAgent>();

	//キャラを回転させる
	transform.Rotate(new Vector3(0.0f, moveHorizontal, 0.0f));

	//キャラの向いている方向に移動
	agent.Move (transform.forward * moveVertical * 0.02f);
	}
}
