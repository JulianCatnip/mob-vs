namespace GoogleARCore.Examples.SimpleARCaptionGenerator
{
	
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ListView : MonoBehaviour {

	public SceneController sceneController; // für user action

	public GameObject captionView;
	public GameObject captionViewEmpty;
	public Transform parent;

	private float yTranslate;

	public void NoCaptions() {
		captionViewEmpty.SetActive (true);
	}

	public void RenderCaptions(List<Caption> _captions) {
		if (_captions.Count != 0) {
			captionViewEmpty.SetActive (false);
			foreach (Caption caption in _captions) {
				int _id = caption.GetId ();
				string _name = caption.GetName ();
				string _position = caption.GetPosition ();

				// panel erzeugen und positionieren
				GameObject captionViewPrefab = Instantiate (captionView, parent, false);
				captionViewPrefab.transform.Translate (0, yTranslate, 0);
				captionViewPrefab.name = "CaptionView" + _id;
				yTranslate -= 250; // -590

				// text setzten
				Transform id = captionViewPrefab.transform.Find ("Id");
				Transform name = captionViewPrefab.transform.Find ("Name");
				Transform position = captionViewPrefab.transform.Find ("Position");

				id.GetComponent<Text> ().text = _id + "";
				name.GetComponent<Text> ().text = _name;
				position.GetComponent<Text> ().text = _position;

				// button aktivieren
				Button deleteButton = captionViewPrefab.transform.Find ("DeleteButton").GetComponent<Button> ();
				deleteButton.onClick.AddListener (delegate {
					sceneController.DeleteCaptionById (_id);
				});
			}
		} else {
			captionViewEmpty.SetActive (true);
		}
	}

	public void Reset() {
		Transform generated = transform.Find ("Canvas/Generated");
		foreach (Transform child in generated) {
			Destroy (child.gameObject);
		}
		yTranslate = 0;
	}

	// Use this for initialization
	void Start () {
		yTranslate = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
}