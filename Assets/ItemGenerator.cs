using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGenerator : MonoBehaviour
{
    string randomPointPrefab1 = GameObject.Find("RandomPoint(1)");
    string randomPointPrefab2 = GameObject.Find("RandomPoint(2)");
    string randomPointPrefab3 = GameObject.Find("RandomPoint(3)");
    string randomPointPrefab4 = GameObject.Find("RandomPoint(4)");
    string randomPointPrefab5 = GameObject.Find("RandomPoint(5)");
    string randomPointPrefab6 = GameObject.Find("RandomPoint(6)");
    string randomPointPrefab7 = GameObject.Find("RandomPoint(7)");
    string randomPointPrefab8 = GameObject.Find("RandomPoint(8)");
    string randomPointPrefab9 = GameObject.Find("RandomPoint(9)");
    string randomPointPrefab10 = GameObject.Find("RandomPoint(10)");
    string randomPointPrefab11 = GameObject.Find("RandomPoint(11)");
    string randomPointPrefab12 = GameObject.Find("RandomPoint(12)");
    string randomPointPrefab13 = GameObject.Find("RandomPoint(13)");
    string randomPointPrefab14 = GameObject.Find("RandomPoint(14)");
    string randomPointPrefab15 = GameObject.Find("RandomPoint(15)");

    public var RandomPointList = new List<string>();
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
        
    void Start ()
    {  
        for (int i = 0; i < 10; i++)
        {
            var randomPoint = Random.Range(0, RandomPointList.Count);

            float x = randomPoint.x;
            float y = randomPoint.y;
            float z = randomPoint.z;

            GameObject GoldCoins = GameObject.Find("GoldCoins");
            GameObject goldCoins  = Instantiate(GoldCoins) as GameObject;
            goldCoins.transform.position = new Vector3(x, y, z);

            RandomPointList.RemoveAt (randomPoint);
        }
    }

    // Update is called once per frame
    void Update ()
    {

    }
}
