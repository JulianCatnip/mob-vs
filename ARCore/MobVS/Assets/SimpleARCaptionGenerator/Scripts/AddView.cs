namespace GoogleARCore.Examples.SimpleARCaptionGenerator
{

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddView : MonoBehaviour {

	private Transform inputView;

	public void UpdateSaveButton(Transform toUpdate) {
		toUpdate.transform.Find ("SaveText").GetComponent<Text> ().text = "Saved.";
		toUpdate.transform.Find ("SaveText").GetComponent<Text> ().color = Color.black;
		toUpdate.GetComponent<Button> ().interactable = false;
	}

	public void Reset() {
		// Reset Button 
		inputView = transform.Find ("Canvas").transform.Find ("InputView");
		Button saveButton = inputView.GetComponentInChildren<Button> ();
		saveButton.interactable = true;
		saveButton.GetComponentInChildren<Text>().text = "Save";
		saveButton.GetComponentInChildren<Text> ().color = Color.white;

		// Reset Text
		Transform inputName = inputView.Find("InputFieldName");
		Transform inputPosition = inputView.Find("InputFieldPosition");
		Transform textName = inputName.Find ("InputTextName");
		Transform textPosition = inputPosition.Find ("InputTextPosition");
		textName.GetComponent<Text>().text = "";
		textPosition.GetComponent<Text>().text = "";
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
}