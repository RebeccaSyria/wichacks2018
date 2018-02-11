using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterBed : MonoBehaviour {
	string[] hey = new string[1];

	private void OnTriggerStay2D(Collider2D collision){
	if(Input.GetKey(KeyCode.Space)){
		hey[0] = "shit shit HI";
		createTextBox();}
}

	public GameObject createTextBox(){
        GameObject obj = Instantiate(Resources.Load("TextDisplay") as GameObject);
        obj.GetComponentInChildren<TextAdvance>().Init(hey);
         return obj;
	}}
