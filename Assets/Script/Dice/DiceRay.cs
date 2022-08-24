using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceRay : MonoBehaviour
{
    private const float RAYDISTANCE = 10f;
    private Vector3 dir = new Vector3(0, 0, 1f);
    private Vector3 rayOriginPos = new Vector3(0, 0, -1f);

    private DiceManager diceManagerIns;

    public RaycastHit ray;


    private void Start()
    {
        diceManagerIns = DiceManager.Instance;
    }

    private void Update()
    {
        Debug.DrawRay(rayOriginPos, dir, new Color(1, 0, 0));

        if (Physics.Raycast(rayOriginPos, dir, out ray, RAYDISTANCE))
        {
            RayCasts();
        }
    }

    /// <summary>
    /// 레이저에 닿은 컨테이너에 Dice가 있다면 
    /// diceManagerIns.currentCollidDice에 컨테이너에 있는 주사위를 저장한다
    /// 아니면 null
    /// </summary>
    private void RayCasts()
    {
        var con = ray.collider.GetComponent<Container>();
        if (ray.collider.CompareTag("Container") && con.dice != null)
        {
            diceManagerIns.currentCollidDice = con.dice;
        }
        else
        {
            diceManagerIns.currentCollidDice = null;
        }
    }
}
