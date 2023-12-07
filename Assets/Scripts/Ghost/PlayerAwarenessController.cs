using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAwarenessController : MonoBehaviour
{
    public bool PlayerAwareness { get; private set; }

    public Vector2 DirectionPlayer { get; private set; }

    [SerializeField]
    private float PlayerAwarenessDistance;

    private Transform target;

    private void Awake()
    {
        target = FindObjectOfType<Movement>().transform;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 enemyToPlayerVector = target.position - transform.position;
        DirectionPlayer = enemyToPlayerVector.normalized;

        if (enemyToPlayerVector.magnitude <= PlayerAwarenessDistance)
        {
            PlayerAwareness = true;
        }
        else
        {
            PlayerAwareness = false;
        }
    }
}
