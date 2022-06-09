using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetLocator : MonoBehaviour
{
    [SerializeField] Transform weapon;
    Transform target;
    
    void Start()
    {
        target = FindObjectOfType<EnemyMovement>().transform;
    }

    
    void Update()
    {
        Aimweapon();  
    }

    void Aimweapon()
    {
        weapon.LookAt(target);
    }
}
