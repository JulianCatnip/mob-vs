using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ARKitSDK.SimpleARCaptionGenerator {
	
	/// <summary>
	/// This Script controls the presentation.
	/// The pages are drawn out of the resources folder and have to be in order 01-...
	/// </summary>
	public class PresentationControl : MonoBehaviour {

		private Object[] allSheets;
		private int currentSheet = 0;

		// Use this for initialization
		void Start () {
			// Alle Folien aus Resources beziehen
			allSheets = Resources.LoadAll("Textures/Presentation", typeof(Texture2D));
			// Erste Textur auf plane setzen
			Texture2D texture = (Texture2D) allSheets[0];
			transform.Find("Plane").GetComponent<Renderer>().material.mainTexture = texture;

		}

		/// <summary>
		/// Called if the left invisible button got touched. 
		/// </summary>
		public void PreviousFoil() {
			// wenn currentsheet > 0
			if (currentSheet > 0) {
				// currentsheet -1
				currentSheet--;
				Texture2D texture = (Texture2D) allSheets[currentSheet];
				transform.Find("Plane").GetComponent<Renderer>().material.mainTexture = texture;
			}
			// andernfalls nix tun
		}

		/// <summary>
		/// Called if the right invisible button got touched. 
		/// </summary>
		public void NextFoil() {
			// wenn currentsheet < allsheets.length
			if (currentSheet < allSheets.Length) {
				// currentsheet +1
				currentSheet++;
				Texture2D texture = (Texture2D) allSheets[currentSheet];
				transform.Find("Plane").GetComponent<Renderer>().material.mainTexture = texture;
			}
			// andernfalls nix tun
		}
		
		// Update is called once per frame
		void Update () {
			
		}
	}
}