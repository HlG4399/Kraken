using UnityEngine;
using System.Collections;

/// <summary>
/// 主动攻击:发出水波攻击范围内的敌人,没有面向限制,就是周围一圈的敌人都可以攻击.
/// </summary>
public class ActiveAttack : MonoBehaviour
{
    public GameObject waterWave;
    void Update()
    {
        if(Input.GetKey(KeyCode.A))
        {
            waterWave.SetActive(true);
        }
        if(Input.GetKeyUp(KeyCode.A))
        {
            waterWave.SetActive(false);
        }
    }
}
