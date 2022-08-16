using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum EPoolObjs
{
    
    FireDice,
    IceDice,
    ElectroDice,
    UnFixDice,
    WindDice,
    Enemy,
    Bullet,
}
public class ObjPool : Singleton<ObjPool>
{

    public List<BaseAll> baseObjs = new List<BaseAll>();

    private Dictionary<EPoolObjs, Queue<BaseAll>> pool = new Dictionary<EPoolObjs, Queue<BaseAll>>();




    public BaseAll Get(EPoolObjs type, Vector3 pos)
    {
        BaseAll obj = null;

        if(pool.ContainsKey(type) == false)
        {
            pool.Add(type, new Queue<BaseAll>());
        }

        Queue<BaseAll> queue = pool[type];

        BaseAll origin = baseObjs[(int)type];

        if(queue.Count > 0)
        {
            obj = queue.Dequeue();
        }
        else
        {
            obj = Instantiate(origin);
        }
        obj.gameObject.SetActive(true);
        obj.transform.position = pos;

        return obj;
    }

    public T Get<T>(EPoolObjs type, Vector3 pos) where T : MonoBehaviour
    {
        return Get(type, pos).GetComponent<T>();
    }
    /// <summary>
    /// 돌려줘
    /// </summary>
    /// <param name="type">무슨타입인데?</param>
    /// <param name="ba">무슨 오브젝트인데?</param>
    public void Return(EPoolObjs type, BaseAll ba)
    {
        ba.gameObject.SetActive(false);
        pool[type].Enqueue(ba);
    }


}
