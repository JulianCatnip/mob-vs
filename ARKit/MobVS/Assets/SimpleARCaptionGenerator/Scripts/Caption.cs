using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ARKitSDK.SimpleARCaptionGenerator {

	/// <summary>
	/// This Script represents a caption model.
	/// </summary>
	public class Caption : MonoBehaviour {

		private int id; // the id of an object
		private string c_name; // the name value
		private string position; // the position value
		private GameObject anchor; // the anchor of this object
		private GameObject captionModel; // the 3d model of this object

		// getter & setter

		public int GetId() {
			return id;
		}

		public void SetId(int _id) {
			id = _id;
		}

		public string GetName() {
			return c_name;
		}

		public void SetName(string _name) {
			c_name = _name;
		}

		public string GetPosition() {
			return position;
		}

		public void SetPosition(string _position) {
			position = _position;
		}

		public GameObject GetAnchor() {
			return anchor;
		}

		public void SetAnchor(GameObject _anchor) {
			anchor = _anchor;
		}
		
		public GameObject GetCaptionModel() {
			return captionModel;		
		}

		public void SetCaptionModel(GameObject _captionModel) {
			captionModel = _captionModel;
		}
	}
}