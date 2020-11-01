using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;

public class SportyGirlController : MonoBehaviour
{
	public int point = 1;
	public Vector3 position;
	public Text pointText;
	private bool isEnd = false;
    private GameObject stateText;
	Rigidbody rbSportyGirl;
	NavMeshAgent agent;

    void Start()
   {
		Transform startPosition = this.gameObject.GetComponent<Transform> ();
		startPosition.transform.position = new Vector3(21.3f, 0.3f, 1.0f);
		this.stateText = GameObject.Find("GameResultText");
		agent = GetComponent<NavMeshAgent>();
   }
   void Update () 
   {
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");
		transform.Rotate(new Vector3(0.0f, moveHorizontal, 0.0f));
		if(isEnd == false)
		{
			agent.destination = transform.position + transform.forward * moveVertical * 1.0f;
		}
   }
   void OnTriggerEnter(Collider other)
   {
		rbSportyGirl = GetComponent<Rigidbody>();
		var rbEnemy = GameObject.Find ("mummy@attack").GetComponent<Rigidbody> (); 
		if(other.gameObject.tag == "Enemy1")
		{
			point -= 1;
			pointText.text = point.ToString();
		}
		GameObject startGoal = GameObject.Find("StartGoal");
		if(other.gameObject.tag == "GoldCoinsTag")
        {
			Destroy(other.gameObject);
			point += 1;
			pointText.text = point.ToString();
        }
		if(point < 1)
		{
			isEnd = true;
		}
		if(isEnd == true)
		{
			this.stateText.GetComponent<Text>().text = "GAME OVER";
			agent.enabled = false;
		}
		if(other.gameObject.tag == "StartGoalTag")
		{
			isEnd = true;
			this.stateText.GetComponent<Text>().text = "GOAL";
			agent.enabled = false;
		}
   }
}
