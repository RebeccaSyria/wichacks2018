using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextWriter : MonoBehaviour {
	string inputString = "oh boy";
	TextMeshPro text;
	public void Init (string textToPrint){
		inputString = textToPrint;
	}
	IEnumerator write(){
		for (int i =0; i <= inputString.Length; i++){
			Debug.Log("what the shit");
			yield return new WaitForSeconds(0.05F);
			text.SetText(inputString.Substring(0,i));
		}
	}
	// Use this for initialization
	void Start () {
		text = GameObject.Find("TextDisplay(Clone)").GetComponentInChildren<TextMeshPro>();
		StartCoroutine("write");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
