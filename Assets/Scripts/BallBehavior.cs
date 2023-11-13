using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBehavior : MonoBehaviour
{
    private float score;
    private ScoreSystem scoreSystem;
    // Start is called before the first frame update
    void Start()
    {
        scoreSystem = GameObject.Find("ScoreSystem").GetComponent<ScoreSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other) 
    {
        if (other.gameObject.CompareTag("ColliderScore"))
        {
            score = other.gameObject.GetComponent<ColliderScore>().score;
            scoreSystem.GetScore(score);
            Debug.Log("Score: " + score);
        }
    }
}
