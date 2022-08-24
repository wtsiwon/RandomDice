using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceRay : MonoBehaviour
{
    private const float RAYDISTANCE = 10f;
    private Vector3 dir = new Vector3(0, 0, 1f);
    private Vector3 rayOriginPos = new Vector3(0, 0, -1f);

    public RaycastHit ray;

    //주사위 하고 부딪혔냐
    public bool isDice;

    //드래그 중인가?
    public bool isDragging;

    private void Update()
    {
        RayCasts();
    }
    /// <summary>
    /// 레이저 쏘는 함수
    /// </summary>
    private void RayCasts()
    {
        Debug.DrawRay(rayOriginPos, dir, new Color(1, 0, 0));

        if (Physics.Raycast(rayOriginPos, dir, out ray, RAYDISTANCE))
        {
            if (ray.collider.CompareTag("Dice"))
            {
                isDice = true;
            }
        }
    }
}
