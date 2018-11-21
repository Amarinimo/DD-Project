using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider))]

public class EnemyBehaviour : MonoBehaviour
{
    [SerializeField]
    private GameObject enemy;
    [SerializeField]
    private int hitpoints;

    private void OnTriggerEnter(Collider other)
    {
        hitpoints -= 1;
        Destroy(other.gameObject);
        if (hitpoints == 0)
        {
            Destroy(enemy);
        }
    }
}
