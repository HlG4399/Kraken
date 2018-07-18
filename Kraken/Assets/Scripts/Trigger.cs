using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour {
	/// <summary>
	/// 触发器开关
	/// </summary>
	// Use this for initialization
	public bool isTriggered=false;
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter(Collider other){
		if (other.tag == "Player") {
			isTriggered = true;
		}
	}
}
