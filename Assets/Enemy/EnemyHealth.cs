using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{

    [SerializeField] int maxHitPoints = 5;
    [SerializeField] int currentHitpoints = 0;

    Enemy enemy;


    void OnEnable()
    {
        currentHitpoints = maxHitPoints;
    }

    void Start()
    {
        enemy = GetComponent<Enemy>();  
    }

    void OnParticleCollision(GameObject other)
    {
        ProcessHit();
    }

    void ProcessHit()
    {
        currentHitpoints --;
        if (currentHitpoints <= 0)
        {
            gameObject.SetActive(false);
            enemy.RewardGold();
        }
    }



}
