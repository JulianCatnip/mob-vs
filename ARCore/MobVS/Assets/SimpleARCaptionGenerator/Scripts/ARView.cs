namespace GoogleARCore.Examples.SimpleARCaptionGenerator
{

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using GoogleARCore;
using GoogleARCore.Examples.Common;

#if UNITY_EDITOR
// Set up touch input propagation while using Instant Preview in the editor.
using Input = InstantPreviewInput;
#endif

public class ARView : MonoBehaviour {

	public SceneController sceneController;
	public Button goBackButton;
	public Button hideGUIButton;
	public Dropdown dropDown;
	private int dropdownValue;
	private List<Caption> captions;

	public Camera FirstPersonCamera;
	public GameObject CaptionPrefab;
	public GameObject PresentationPlane;
	public GameObject SearchingForPlaneUI;
	public float offsetY = 1.0f;

	private List<DetectedPlane> m_AllPlanes = new List<DetectedPlane>();
	private DetectedPlane selectedPlane;
	private bool m_IsQuitting = false;

	void Start() {
		PresentationPlane.gameObject.SetActive (false);
	}

	public void SetDropDown(List<Caption> _captions) {
		captions = _captions;
		dropDown.ClearOptions ();
		List<string> captionlist = new List<string> ();
		captionlist.Add ("Plane"); // Plane
		foreach (Caption caption in captions) { // Captions
			string id = caption.GetId () + "";
			captionlist.Add (id);
		}
		dropDown.AddOptions (captionlist);
	}
	
	public void	TrackPlanes() {
		_UpdateApplicationLifecycle();

		// Hide snackbar when currently tracking at least one plane.
		Session.GetTrackables<DetectedPlane>(m_AllPlanes);
		bool showSearchingUI = true;
		for (int i = 0; i < m_AllPlanes.Count; i++) {
			if (m_AllPlanes[i].TrackingState == TrackingState.Tracking) {
				showSearchingUI = false;
				break;
			}
		}

		SearchingForPlaneUI.SetActive(showSearchingUI);
	}

	public void ProcessTouches () {
			
		Touch touch;
		if (Input.touchCount != 1 || (touch = Input.GetTouch (0)).phase != TouchPhase.Began) {
			return;
		} 

		TrackableHit hit;
		TrackableHitFlags raycastFilter = TrackableHitFlags.PlaneWithinBounds | TrackableHitFlags.PlaneWithinPolygon;

		if (Frame.Raycast (touch.position.x, touch.position.y, raycastFilter, out hit)) {
			SetSelectedPlane (hit.Trackable as DetectedPlane, hit);
		}
	}
	
	public void SetSelectedPlane(DetectedPlane _selectedPlane, TrackableHit hit) {
		this.selectedPlane = _selectedPlane;
		CreateAnchor(hit);
	}

	public void	CreateAnchor(TrackableHit hit) {

		if (GetDropDownValue ().Equals ("Plane")) { // falls plane ausgewählt
			if (PresentationPlane.gameObject.activeSelf != true) { // plane aktivieren
				PresentationPlane.gameObject.SetActive (true);
			}
			// wenn plane bereits anchor hat
			if (PresentationPlane.transform.parent.name.Equals ("Anchor")) {
				Transform oldAnchor = PresentationPlane.transform.parent; // alten anchor speichern
				Anchor newAnchor = selectedPlane.CreateAnchor (hit.Pose); // neuen anchor erzeugen
				newAnchor.transform.parent = transform.Find ("Generated");
				PresentationPlane.transform.position = newAnchor.transform.position; 
				PresentationPlane.transform.Translate (Vector2.up * (offsetY + 0.5f));
				PresentationPlane.transform.parent = newAnchor.transform; // der plane den neuen anchor zuweisen
				DestroyObject (oldAnchor.gameObject); // alten anchor löschen
			} else {
				Anchor newAnchor = selectedPlane.CreateAnchor (hit.Pose); // neuen anchor erzeugen
				newAnchor.transform.parent = transform.Find ("Generated");
				PresentationPlane.transform.position = newAnchor.transform.position; 
				PresentationPlane.transform.Translate (Vector2.up * (offsetY + 0.5f));
				PresentationPlane.transform.parent = newAnchor.transform; // der plane den neuen anchor zuweisen
			}

		} else {
			int.TryParse (GetDropDownValue (), out dropdownValue); // string in int umwandeln
			// caption objekt trägt einen ankerpunkt
			foreach (Caption caption in captions) {
				if (caption.GetId () == dropdownValue) {
					if (caption.GetAnchor () != null) { // wenn caption schon einen anker hat
						DestroyObject (caption.GetAnchor ());
					}
					Anchor anchor = selectedPlane.CreateAnchor (hit.Pose);
					anchor.transform.parent = transform.Find ("Generated");
					if (caption.GetCaptionModel () == null) {
						string name = caption.GetName ();
						string position = caption.GetPosition ();
						GameObject captionModel = CreateCaptionModel (name, position);
						caption.SetCaptionModel (captionModel);
					}
					caption.SetAnchor (anchor);
					caption.GetCaptionModel ().transform.position = caption.GetAnchor ().transform.position;
					caption.GetCaptionModel ().transform.Translate (Vector2.up * offsetY);
					caption.GetCaptionModel ().transform.parent = caption.GetAnchor ().transform;
				}
			}
		}
	}

	public void HideGUIButtonClicked() {
		goBackButton.gameObject.SetActive (false);
		hideGUIButton.gameObject.SetActive (false);
		dropDown.gameObject.SetActive (false);
		// Trackingplane ausblenden
		foreach (GameObject plane in GameObject.FindGameObjectsWithTag("Plane")) {	
			plane.SetActive (false);
		}
	}

	public void ActivateGUI() {
		goBackButton.gameObject.SetActive (true);
		hideGUIButton.gameObject.SetActive (true);
		dropDown.gameObject.SetActive (true);
		// Trackingplane ausblenden
		foreach (GameObject plane in GameObject.FindGameObjectsWithTag("Plane")) {	
			plane.SetActive (true);
		}
	}

	public string GetDropDownValue() {
		return dropDown.captionText.text;
	}

	public GameObject CreateCaptionModel(string _name, string _position) {
		GameObject newCaption = Instantiate(CaptionPrefab, transform.Find("Generated"), true);
		newCaption.GetComponent<Plotter>().Set3DText(_name, _position);
		return newCaption;
	}

	public void	LookAtCamera() {
		foreach (Caption caption in captions) {
			if (caption.GetCaptionModel () != null) {
				caption.GetCaptionModel ().transform.LookAt (FirstPersonCamera.transform);
			}
		}
	}
	
	private void _UpdateApplicationLifecycle() {
		// Exit the app when the 'back' button is pressed.
		if (Input.GetKey(KeyCode.Escape)) {
			//Application.Quit();
			ActivateGUI();
		}
		
		// Only allow the screen to sleep when not tracking.
		if (Session.Status != SessionStatus.Tracking) {
			const int lostTrackingSleepTimeout = 15;
			Screen.sleepTimeout = lostTrackingSleepTimeout;
		} else {
			Screen.sleepTimeout = SleepTimeout.NeverSleep;
		}

		if (m_IsQuitting) {
			return;
		}

		// Quit if ARCore was unable to connect and give Unity some time for the toast to appear.
		if (Session.Status == SessionStatus.ErrorPermissionNotGranted) {
			_ShowAndroidToastMessage("Camera permission is needed to run this application.");
			m_IsQuitting = true;
			Invoke("_DoQuit", 0.5f);
		} else if (Session.Status.IsError()) {
			_ShowAndroidToastMessage("ARCore encountered a problem connecting.  Please start the app again.");
			m_IsQuitting = true;
			Invoke("_DoQuit", 0.5f);
		}
	}

	private void _DoQuit() {
		Application.Quit();
	}

	private void _ShowAndroidToastMessage(string message) {
		AndroidJavaClass unityPlayer = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
		AndroidJavaObject unityActivity = unityPlayer.GetStatic<AndroidJavaObject>("currentActivity");

		if (unityActivity != null) {
			AndroidJavaClass toastClass = new AndroidJavaClass("android.widget.Toast");
			unityActivity.Call("runOnUiThread", new AndroidJavaRunnable(() =>
				{
					AndroidJavaObject toastObject = toastClass.CallStatic<AndroidJavaObject>("makeText", unityActivity, message, 0);
					toastObject.Call("show");
				}));
		}
	}
	
	// Update is called once per frame
	void Update () {
		
		if(PresentationPlane.gameObject.activeSelf == true) {
			PresentationPlane.transform.LookAt(FirstPersonCamera.transform);
		}
		if (captions.Count > 0) {
			foreach (Caption caption in captions) {
				if (caption.GetCaptionModel () != null) {
					caption.GetCaptionModel ().transform.LookAt (FirstPersonCamera.transform);
				}
			}
		}
	}
}
}