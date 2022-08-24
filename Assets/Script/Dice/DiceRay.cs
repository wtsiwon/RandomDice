using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceRay : MonoBehaviour
{
    private const float RAYDISTANCE = 10f;
    private Vector3 dir = new Vector3(0, 0, 1f);
    private Vector3 rayOriginPos = new Vector3(0, 0, -1f);

    public RaycastHit ray;

    //�ֻ��� �ϰ� �ε�����
    public bool isDice;

    //�巡�� ���ΰ�?
    public bool isDragging;

    private void Update()
    {
        RayCasts();
    }
    /// <summary>
    /// ������ ��� �Լ�
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
