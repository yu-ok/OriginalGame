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

    // Start is called before the first frame update
    void Start()
   {
		Transform startPosition = this.gameObject.GetComponent<Transform> ();
		startPosition.transform.position = new Vector3(21.3f, 0.3f, 0.0f);

		this.stateText = GameObject.Find("GameResultText");
   }

   void Update () 
   {
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");
		NavMeshAgent agent = GetComponent<NavMeshAgent>();

		//キャラを回転させる
		transform.Rotate(new Vector3(0.0f, moveHorizontal, 0.0f));

		//position += transform.forward * moveVertical * 0.02f;
		agent.destination = transform.position + transform.forward * moveVertical * 1.0f;
   }

   void OnTriggerEnter(Collider other)
   {
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
		}

		if(other.gameObject.tag == "Enemy1")
		{
			point -= 1;
		}
   }
}
