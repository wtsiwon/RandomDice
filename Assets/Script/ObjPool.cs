using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum EPoolObjs
{
    Enemy,
    Bullet,
    FireDice,
    IceDice,
    ElectroDice,
    UnFixDice,
    WindDice,
}
public class ObjPool : Singleton<ObjPool>
{
    private Dictionary<EPoolObjs, BaseAll> pool = new Dictionary<EPoolObjs, BaseAll>();
}
