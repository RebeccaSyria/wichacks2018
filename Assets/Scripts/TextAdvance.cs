using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextAdvance : MonoBehaviour {

	string[] input;
        TextMeshPro text;
	int counter = -1;
        
	public void Init (string[] textToPrint){
                input = textToPrint;
        }
        IEnumerator writeText(){
		counter ++;
                for (int i =0; i <= input[counter].Length; i++){
                        Debug.Log("what the shit");
                        yield return new WaitForSeconds(0.05F);
                        text.SetText(input[counter].Substring(0,i));
                }
        }
        // Use this for initialization
        void Start (){ 
		input = new string[1];
                text = GameObject.Find("TextDisplay(Clone)").GetComponentInChildren<TextMeshPro>();
		input[0] = "hey hey hey";
                StartCoroutine("writeText");
        }

        // Update is called once per frame
        void Update () {
		if(Input.GetMouseButtonDown(0)){
			if(counter == input.Length-1){
				Destroy(GameObject.Find("TextDisplay(Clone)"));
			}else{
			StartCoroutine("writeText");
			}
		}

        
	}}

