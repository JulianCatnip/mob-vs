using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ARKitSDK.SimpleARCaptionGenerator {

	/// <summary>
	/// This Script controls the AddView.
	/// </summary>
	public class AddView : MonoBehaviour {

		private Transform inputView; // The Input Field
		
		/// <summary>
		/// Updates the Save-Button if touched.
		/// </summary>
		/// <param name="toUpdate">Transform Object to change</param>
		public void UpdateSaveButton(Transform toUpdate) {
			toUpdate.transform.Find ("SaveText").GetComponent<Text> ().text = "Saved.";
			toUpdate.transform.Find ("SaveText").GetComponent<Text> ().color = Color.black;
			toUpdate.GetComponent<Button> ().interactable = false;
		}

		/// <summary>
		/// Resets the Save-Button.
		/// </summary>
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