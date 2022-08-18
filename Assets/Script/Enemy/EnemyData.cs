using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "EnemyData", menuName = "Datas/EnemyData",order = 0)]
public class EnemyData : ScriptableObject
{
    public Stat stat;
    public float multi = 1;

    [Tooltip("���� Wave�� �������� �����")]
    public int money;
}
