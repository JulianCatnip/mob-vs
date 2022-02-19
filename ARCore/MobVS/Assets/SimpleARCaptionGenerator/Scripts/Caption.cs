namespace GoogleARCore.Examples.SimpleARCaptionGenerator
{

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Caption : MonoBehaviour {

	private int id;
	private string c_name;
	private string position;
	private Anchor anchor;
	private GameObject captionModel;

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

	public Anchor GetAnchor() {
		return anchor;
	}

	public void SetAnchor(Anchor _anchor) {
		anchor = _anchor;
	}
	
	public GameObject GetCaptionModel() {
		return captionModel;		
	}

	public void SetCaptionModel(GameObject _captionModel) {
		captionModel = _captionModel;
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
}