using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerController : MonoBehaviour
{
	public Text timerText;
	public float totalTime;
	int seconds;

	// Use this for initialization
	void Start () 
	{
		
	}

	// Update is called once per frame
	void Update () 
	{
		totalTime -= Time.deltaTime;
		seconds = (int)totalTime;
		timerText.text= seconds.ToString();
		private GameObject sportyGirl = GameObject.Find("SportyGirl");
		private bool isEnd = sportyGirl.GetComponent<SportyGirlController> ().isEnd;

		if (isEnd == true)
		{
			totalTime += Time.deltaTime;
		}

	}
}
