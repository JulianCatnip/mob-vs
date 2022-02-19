namespace GoogleARCore.Examples.SimpleARCaptionGenerator
{

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using GoogleARCore;

public enum AppState {
	LIST,
	ADD,
	AR
}

public class SceneController : MonoBehaviour {

	private static int ID = 1;
	private List<Caption> captions;

	public GameObject listView;
	public GameObject addView;
	public GameObject arView;

	public GameObject inputView;

	private AppState appState;
	private bool methodCalled = false;

	public void AddCaption(string _name, string _position) {
		Caption newCaption = new Caption ();
		newCaption.SetId (ID++);
		newCaption.SetName (_name);
		newCaption.SetPosition (_position);
		captions.Add (newCaption);
	}

	public List<Caption> GetCaption() {
		return captions;
	}

	public void SetCaptions(List<Caption> _captions){
		captions = _captions;
	}

	public Caption GetCaptionById(int _id) {
		foreach (Caption caption in captions) {
			if(caption.GetId() == _id){
				return caption;
			}
		}
		return null;
	}

	public void DeleteCaptionById(int _id) { // bei button klick
		// aus liste löschen
		captions.RemoveAll(caption => caption.GetId() == _id); // listeneintrag entfernen

		// liste neu rendern
		listView.GetComponent<ListView>().Reset (); // alle gerenderten löschen
		listView.GetComponent<ListView> ().RenderCaptions (captions); // neurendern

	}

	public void AddButtonClicked() {
		appState = AppState.ADD;
		methodCalled = false;
	}

	public void SaveInput() {
		// Daten auslesen
		string _name = inputView.transform.Find ("InputFieldName/InputTextName").GetComponent<Text> ().text;
		string _position = inputView.transform.Find ("InputFieldPosition/InputTextPosition").GetComponent<Text> ().text;
		AddCaption (_name, _position);

		// save bestätigen
		Transform saveButton = inputView.transform.Find ("SaveButton");
		addView.GetComponent<AddView>().UpdateSaveButton(saveButton);
	}

	public void HomeButtonClicked() {
		appState = AppState.LIST;
		methodCalled = false;
	}

	public void SetAnchorButtonClicked() {
		appState = AppState.AR;
		methodCalled = false;
	}

	// Use this for initialization
	void Start () {
		appState = AppState.LIST;
		captions = new List<Caption> ();

		listView.SetActive (true);
		addView.SetActive (false);
		arView.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		switch(appState) {
			case AppState.LIST:
				if (!methodCalled) {
					listView.SetActive (true);
					addView.SetActive (false);
					arView.SetActive (false);

					// reset
					listView.GetComponent<ListView>().Reset ();

					if (captions.Count == 0) {
						listView.GetComponent<ListView> ().NoCaptions ();
						Button anchorButton = listView.transform.Find ("Canvas/Footer/AnchorButton").GetComponent<Button> ();
						anchorButton.interactable = false;
						methodCalled = true;
					} else {
						listView.GetComponent<ListView> ().RenderCaptions (captions);
						Button anchorButton = listView.transform.Find ("Canvas/Footer/AnchorButton").GetComponent<Button> ();
						anchorButton.interactable = true;
						methodCalled = true;
					}
				}

				; break;
			case AppState.ADD:
				if (!methodCalled) {
					// add view aktivieren
					listView.SetActive (false);
					addView.SetActive (true);
					arView.SetActive (false);
					
					// reset
					addView.GetComponent<AddView>().Reset ();

					methodCalled = true;
				}
				; break;
			case AppState.AR:
				if (!methodCalled) { // start/bzw einmaliger aufruf
					// add view aktivieren
					listView.SetActive (false);
					addView.SetActive (false);
					arView.SetActive (true);
					arView.GetComponent<ARView> ().SetDropDown (captions);

					methodCalled = true;
				}

				arView.GetComponent<ARView> ().TrackPlanes ();
				arView.GetComponent<ARView> ().ProcessTouches();
				//arView.GetComponent<ARView> ().LookAtCamera();
				// captionprefab in generated ordner erzeugen
				// captionprefab an hit platzieren
				// drehung zur kamera

				; break;
		}
	}
}
}