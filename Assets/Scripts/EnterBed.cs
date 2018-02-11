using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterBed : MonoBehaviour {
	private void OnTriggerStay2D(Collider2D collision){
	if(Input.GetKey(KeyCode.Space)){
		UnityEngine.Object x = Instantiate(Resources.Load("TextDisplay"));

	}
}
}
