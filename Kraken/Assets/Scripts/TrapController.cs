using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 触发两个开关，使boss头上的石头掉落
/// </summary>
public class TrapController : MonoBehaviour {
	public Rigidbody trap_store;//石头
	public Trigger trigger1;//触发器1
	public Trigger trigger2;//触发器2 
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(trigger1.isTriggered&&trigger2.isTriggered){//开关1、2都被触发时
			trap_store.useGravity = true;//开启重力
		}

	}
}