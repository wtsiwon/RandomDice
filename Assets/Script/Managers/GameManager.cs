using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GameManager : Singleton<GameManager>
{
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
}
