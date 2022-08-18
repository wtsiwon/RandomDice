using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField]
    private EnemyData enemyData;
    public EnemyData EnemyData
    {
        get
        {
            return enemyData;
        }
    }
}
