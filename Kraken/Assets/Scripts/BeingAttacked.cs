using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 敌人受到攻击时执行该脚本
/// </summary>
public class BeingAttacked : MonoBehaviour
{
    void OnParticleCollision(GameObject obj)
    {
        if(obj.tag=="aa")
        {
            Debug.Log("Test");
        }
    }
}
