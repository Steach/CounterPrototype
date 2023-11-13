using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] GameObject ballPrefab;
    private float boundX = 0;
    private float boundY = 6;
    private float boundZ = 1.9f;
    private Vector3 spawnPos;
    private int countBalls = 0;
    private float timer = 0;
    private float countDown = 1;
    // Start is called before the first frame update
    void Start()
    {
        timer = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        countBalls = GameObject.FindGameObjectsWithTag("Ball").Length;
        //Debug.Log("Balls: " + countBalls);
        if (countBalls <= 20)
        {
            //Debug.Log("if Update");
            Timer();
        }
        
    }

    Vector3 RandomPosition()
    {
        float spawnPosZ = Random.Range(-boundZ, boundZ);
        spawnPos = new Vector3(boundX, boundY, spawnPosZ);
        return spawnPos;
    }

    void SpawnBalls()
    {
        Instantiate(ballPrefab, RandomPosition(), ballPrefab.transform.rotation);
    }

    void Spawner()
    {
        
        foreach (var ball in GameObject.FindGameObjectsWithTag("Ball"))
        {
            countBalls++;
            Debug.Log("Balls: " + countBalls);
        }
    }

    void Timer()
    {
        //Debug.Log("if Timer");
        if (timer + countDown <= Time.time)
        {
            //Debug.Log("if Timer");
            timer = Time.time;
            SpawnBalls();
        }
    }
}
