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

    private RectTransform rt;
    private Dice Dice;

    private void Start()
    {
        rt = GetComponent<RectTransform>();
        Dice = GetComponent<Dice>();

        diceManagerIns = DiceManager.Instance;
    }

    private void Update()
    {
        DrawRay();
    }
    /// <summary>
    /// 래이 그려주는 함수
    /// </summary>
    private void DrawRay()
    {
        if (Dice.isDragging == true)
        {
            Debug.DrawRay(rt.position, dir, new Color(0, 2, 0));
            if (Physics.Raycast(rayOriginPos, dir, out ray, RAYDISTANCE))
            {
                RayCollidDetect();
            }
        }
        print(ray.point);
    }

    /// <summary>
    /// 래이 충돌감지
    /// </summary>
    private void RayCollidDetect()
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
