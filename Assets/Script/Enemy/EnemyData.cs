using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "EnemyData", menuName = "Datas/EnemyData",order = 0)]
public class EnemyData : ScriptableObject
{
    public Stat stat;
    public float multi = 1;

    [Tooltip("현재 Wave에 곱해져서 얻어짐")]
    public int money;
}
