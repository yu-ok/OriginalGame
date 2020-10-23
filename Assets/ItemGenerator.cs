using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGenerator : MonoBehaviour
{
    public GameObject GoldCoins;
    public GameObject[] randomPointsPrefabs;

        
    void Start ()
    {  
        for (int i = 0; i < 10; i++)
        {
            GameObject randomPoint = randomPointsPrefabs[Random.Range(0, randomPointsPrefabs.Length)];
            float randomPosition = this.randomPoint.transform.position;
            //すでに使った地点を除くコードがない

            GameObject goldCoins  = Instantiate(GoldCoins) as GameObject;
            goldCoins.transform.position = new Vector3(randomPosition);

        }
    }

    // Update is called once per frame
    void Update ()
    {

    }
}
