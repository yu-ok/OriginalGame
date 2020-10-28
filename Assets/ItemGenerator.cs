using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGenerator : MonoBehaviour
{
    public GameObject goldCoinsPrefab;
        
    void Start ()
    {  
        GameObject randomPointPrefab1 = GameObject.Find("RandomPoint(1)");
        GameObject randomPointPrefab2 = GameObject.Find("RandomPoint(2)");
        GameObject randomPointPrefab3 = GameObject.Find("RandomPoint(3)");
        GameObject randomPointPrefab4 = GameObject.Find("RandomPoint(4)");
        GameObject randomPointPrefab5 = GameObject.Find("RandomPoint(5)");
        GameObject randomPointPrefab6 = GameObject.Find("RandomPoint(6)");
        GameObject randomPointPrefab7 = GameObject.Find("RandomPoint(7)");
        GameObject randomPointPrefab8 = GameObject.Find("RandomPoint(8)");
        GameObject randomPointPrefab9 = GameObject.Find("RandomPoint(9)");
        GameObject randomPointPrefab10 = GameObject.Find("RandomPoint(10)");
        GameObject randomPointPrefab11 = GameObject.Find("RandomPoint(11)");
        GameObject randomPointPrefab12 = GameObject.Find("RandomPoint(12)");
        GameObject randomPointPrefab13 = GameObject.Find("RandomPoint(13)");
        GameObject randomPointPrefab14 = GameObject.Find("RandomPoint(14)");
        GameObject randomPointPrefab15 = GameObject.Find("RandomPoint(15)");

        var RandomPointList = new List<GameObject>();
        RandomPointList.Add(randomPointPrefab1);
        RandomPointList.Add(randomPointPrefab2);
        RandomPointList.Add(randomPointPrefab3);
        RandomPointList.Add(randomPointPrefab4);
        RandomPointList.Add(randomPointPrefab5);
        RandomPointList.Add(randomPointPrefab6);
        RandomPointList.Add(randomPointPrefab7);
        RandomPointList.Add(randomPointPrefab8);
        RandomPointList.Add(randomPointPrefab9);
        RandomPointList.Add(randomPointPrefab10);
        RandomPointList.Add(randomPointPrefab11);
        RandomPointList.Add(randomPointPrefab12);
        RandomPointList.Add(randomPointPrefab13);
        RandomPointList.Add(randomPointPrefab14);
        RandomPointList.Add(randomPointPrefab15);
    
        for (int i = 0; i < 10; i++)
        {
            var randomPointIndex = Random.Range(0, RandomPointList.Count);

            Vector3 randomPoint = RandomPointList[randomPointIndex].transform.position;

            float x = randomPoint.x;
            float y = randomPoint.y;
            float z = randomPoint.z;

            GameObject goldCoins = Instantiate(goldCoinsPrefab);
            
            goldCoins.transform.position = new Vector3(x, y, z);

            RandomPointList.RemoveAt (randomPointIndex);
        }
    }

    // Update is called once per frame
    void Update ()
    {

    }
}
