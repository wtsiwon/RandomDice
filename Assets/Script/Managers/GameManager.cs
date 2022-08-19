using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Linq;

public class GameManager : Singleton<GameManager>
{

    public List<Enemy> enemies = new List<Enemy>();


    public bool isDrag;

    public float bossTime = 30f;

    public float currentTime;

    public bool isBoss
    {
        get
        {
            return isBoss;
        }
        set
        {
            isBoss = value;
            if (value)
            {
                SpawnBoss();
            }
        }
    }

    public Action SpawnBoss;


    private void Update()
    {
        currentTime += Time.deltaTime;

        if(currentTime > bossTime)
        {
            isBoss = true;
        }
    }
    private void EnemyListSort()
    {
        if (enemies.FirstOrDefault() == null)
        {
            
        }
    }

    private void SelectActiveDice()
    {

    }
}
