using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum EBulletType
{
    Fire,
    Ice,
    Electro,
    UnFix,
    Wind,
}
public class BaseBullet : BaseAll
{
    private EBulletType type;
    public EBulletType GetBulletType()
    {
        return type;
    }
    public void SetBulletType(EBulletType type)
    {
        this.type = type;
    }
}
