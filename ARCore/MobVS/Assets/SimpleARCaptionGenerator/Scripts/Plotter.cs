using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plotter : MonoBehaviour {

	public GameObject APrefab;
	public GameObject BPrefab;
	public GameObject CPrefab;
	public GameObject DPrefab;
	public GameObject EPrefab;
	public GameObject FPrefab;
	public GameObject GPrefab;
	public GameObject HPrefab;
	public GameObject IPrefab;
	public GameObject JPrefab;
	public GameObject KPrefab;
	public GameObject LPrefab;
	public GameObject MPrefab;
	public GameObject NPrefab;
	public GameObject OPrefab;
	public GameObject PPrefab;
	public GameObject QPrefab;
	public GameObject RPrefab;
	public GameObject SPrefab;
	public GameObject TPrefab;
	public GameObject UPrefab;
	public GameObject VPrefab;
	public GameObject WPrefab;
	public GameObject XPrefab;
	public GameObject YPrefab;
	public GameObject ZPrefab;
	public GameObject minusPrefab;

	private float versatz1 = 0.0f;
	private float versatz2 = 0.0f;
	private float absatz = -0.1f;

	public void Set3DText(string _name, string _position) {
		SetText(_name, true);
		SetText(_position, false);
	}

	public void SetText(string _text, bool _title) {
		string behaelter;
		if (_title) {
			behaelter = "Name";
		} else {
			behaelter = "Position";
		}
		// buchstabenprefabs auswählen
		GameObject charA;
		GameObject charB;
		GameObject charC;
		GameObject charD;
		GameObject charE;
		GameObject charF;
		GameObject charG;
		GameObject charH;
		GameObject charI;
		GameObject charJ;
		GameObject charK;
		GameObject charL;
		GameObject charM;
		GameObject charN;
		GameObject charO;
		GameObject charP;
		GameObject charQ;
		GameObject charR;
		GameObject charS;
		GameObject charT;
		GameObject charU;
		GameObject charV;
		GameObject charW;
		GameObject charX;
		GameObject charY;
		GameObject charZ;
		GameObject charMinus;

		foreach(char c in _text){
			switch (c) {
			case 'a': 
				charA = Instantiate (APrefab, transform.Find (behaelter), true);
				if (_title) {
					charA.transform.position = Vector3.right * versatz1;
					versatz1 += 0.1f;
				} else {
					charA.transform.position = Vector3.right * versatz2;
					charA.transform.Translate (Vector3.up * absatz);
					versatz2 += 0.1f;
				}
				; break;
			case 'A': 
				charA = Instantiate (APrefab, transform.Find (behaelter), true);
				if (_title) {
					charA.transform.position = Vector3.right * versatz1;
					versatz1 += 0.1f;
				} else {
					charA.transform.position = Vector3.right * versatz2;
					charA.transform.Translate (Vector3.up * absatz);
					versatz2 += 0.1f;
				}
				; break;
			case 'b':
				charB = Instantiate (BPrefab, transform.Find (behaelter), true);
				if (_title) {
					charB.transform.position = Vector3.right * versatz1;
					versatz1 += 0.1f;
				} else {
					charB.transform.position = Vector3.right * versatz2;
					charB.transform.Translate (Vector3.up * absatz);
					versatz2 += 0.1f;
				}
				; break;
			case 'B':
				charB = Instantiate (BPrefab, transform.Find (behaelter), true);
				if (_title) {
					charB.transform.position = Vector3.right * versatz1;
					versatz1 += 0.1f;
				} else {
					charB.transform.position = Vector3.right * versatz2;
					charB.transform.Translate (Vector3.up * absatz);
					versatz2 += 0.1f;
				}
				; break;
			case 'c':
				charC = Instantiate (CPrefab, transform.Find (behaelter), true);
				if (_title) {
					charC.transform.position = Vector3.right * versatz1;
					versatz1 += 0.1f;
				} else {
					charC.transform.position = Vector3.right * versatz2;
					charC.transform.Translate (Vector3.up * absatz);
					versatz2 += 0.1f;
				}
				; break;
			case 'C':
				charC = Instantiate (CPrefab, transform.Find (behaelter), true);
				if (_title) {
					charC.transform.position = Vector3.right * versatz1;
					versatz1 += 0.1f;
				} else {
					charC.transform.position = Vector3.right * versatz2;
					charC.transform.Translate (Vector3.up * absatz);
					versatz2 += 0.1f;
				}
				; break;
			case 'd':
				charD = Instantiate (DPrefab, transform.Find (behaelter), true);
				if (_title) {
					charD.transform.position = Vector3.right * versatz1;
					versatz1 += 0.1f;
				} else {
					charD.transform.position = Vector3.right * versatz2;
					charD.transform.Translate (Vector3.up * absatz);
					versatz2 += 0.1f;
				}
				; break;
			case 'D':
				charD = Instantiate (DPrefab, transform.Find (behaelter), true);
				if (_title) {
					charD.transform.position = Vector3.right * versatz1;
					versatz1 += 0.1f;
				} else {
					charD.transform.position = Vector3.right * versatz2;
					charD.transform.Translate (Vector3.up * absatz);
					versatz2 += 0.1f;
				}
				; break;
			case 'e':
				charE = Instantiate (EPrefab, transform.Find (behaelter), true);
				if (_title) {
					charE.transform.position = Vector3.right * versatz1;
					versatz1 += 0.1f;
				} else {
					charE.transform.position = Vector3.right * versatz2;
					charE.transform.Translate (Vector3.up * absatz);
					versatz2 += 0.1f;
				}
				; break;
			case 'E':
				charE = Instantiate (EPrefab, transform.Find (behaelter), true);
				if (_title) {
					charE.transform.position = Vector3.right * versatz1;
					versatz1 += 0.1f;
				} else {
					charE.transform.position = Vector3.right * versatz2;
					charE.transform.Translate (Vector3.up * absatz);
					versatz2 += 0.1f;
				}
				; break;
			case 'f':
				charF = Instantiate (FPrefab, transform.Find (behaelter), true);
				if (_title) {
					charF.transform.position = Vector3.right * versatz1;
					versatz1 += 0.1f;
				} else {
					charF.transform.position = Vector3.right * versatz2;
					charF.transform.Translate (Vector3.up * absatz);
					versatz2 += 0.1f;
				}
				; break;
			case 'F':
				charF = Instantiate (FPrefab, transform.Find (behaelter), true);
				if (_title) {
					charF.transform.position = Vector3.right * versatz1;
					versatz1 += 0.1f;
				} else {
					charF.transform.position = Vector3.right * versatz2;
					charF.transform.Translate (Vector3.up * absatz);
					versatz2 += 0.1f;
				}
				; break;
			case 'g':
				charG = Instantiate (GPrefab, transform.Find (behaelter), true);
				if (_title) {
					charG.transform.position = Vector3.right * versatz1;
					versatz1 += 0.1f;
				} else {
					charG.transform.position = Vector3.right * versatz2;
					charG.transform.Translate (Vector3.up * absatz);
					versatz2 += 0.1f;
				}
				; break;
			case 'G':
				charG = Instantiate (GPrefab, transform.Find (behaelter), true);
				if (_title) {
					charG.transform.position = Vector3.right * versatz1;
					versatz1 += 0.1f;
				} else {
					charG.transform.position = Vector3.right * versatz2;
					charG.transform.Translate (Vector3.up * absatz);
					versatz2 += 0.1f;
				}
				; break;
			case 'h':
				charH = Instantiate (HPrefab, transform.Find (behaelter), true);
				if (_title) {
					charH.transform.position = Vector3.right * versatz1;
					versatz1 += 0.1f;
				} else {
					charH.transform.position = Vector3.right * versatz2;
					charH.transform.Translate (Vector3.up * absatz);
					versatz2 += 0.1f;
				}
				; break;
			case 'H':
				charH = Instantiate (HPrefab, transform.Find (behaelter), true);
				if (_title) {
					charH.transform.position = Vector3.right * versatz1;
					versatz1 += 0.1f;
				} else {
					charH.transform.position = Vector3.right * versatz2;
					charH.transform.Translate (Vector3.up * absatz);
					versatz2 += 0.1f;
				}
				; break;
			case 'i':
				charI = Instantiate (IPrefab, transform.Find (behaelter), true);
				if (_title) {
					charI.transform.position = Vector3.right * versatz1;
					versatz1 += 0.1f;
				} else {
					charI.transform.position = Vector3.right * versatz2;
					charI.transform.Translate (Vector3.up * absatz);
					versatz2 += 0.1f;
				}
				; break;
			case 'I':
				charI = Instantiate (IPrefab, transform.Find (behaelter), true);
				if (_title) {
					charI.transform.position = Vector3.right * versatz1;
					versatz1 += 0.1f;
				} else {
					charI.transform.position = Vector3.right * versatz2;
					charI.transform.Translate (Vector3.up * absatz);
					versatz2 += 0.1f;
				}
				; break;
			case 'j':
				charJ = Instantiate (JPrefab, transform.Find (behaelter), true);
				if (_title) {
					charJ.transform.position = Vector3.right * versatz1;
					versatz1 += 0.1f;
				} else {
					charJ.transform.position = Vector3.right * versatz2;
					charJ.transform.Translate (Vector3.up * absatz);
					versatz2 += 0.1f;
				}
				; break;
			case 'J':
				charJ = Instantiate (JPrefab, transform.Find (behaelter), true);
				if (_title) {
					charJ.transform.position = Vector3.right * versatz1;
					versatz1 += 0.1f;
				} else {
					charJ.transform.position = Vector3.right * versatz2;
					charJ.transform.Translate (Vector3.up * absatz);
					versatz2 += 0.1f;
				}
				; break;
			case 'k':
				charK = Instantiate (KPrefab, transform.Find (behaelter), true);
				if (_title) {
					charK.transform.position = Vector3.right * versatz1;
					versatz1 += 0.1f;
				} else {
					charK.transform.position = Vector3.right * versatz2;
					charK.transform.Translate (Vector3.up * absatz);
					versatz2 += 0.1f;
				}
				; break;
			case 'K':
				charK = Instantiate (KPrefab, transform.Find (behaelter), true);
				if (_title) {
					charK.transform.position = Vector3.right * versatz1;
					versatz1 += 0.1f;
				} else {
					charK.transform.position = Vector3.right * versatz2;
					charK.transform.Translate (Vector3.up * absatz);
					versatz2 += 0.1f;
				}
				; break;
			case 'l':
				charL = Instantiate (LPrefab, transform.Find (behaelter), true);
				if (_title) {
					charL.transform.position = Vector3.right * versatz1;
					versatz1 += 0.1f;
				} else {
					charL.transform.position = Vector3.right * versatz2;
					charL.transform.Translate (Vector3.up * absatz);
					versatz2 += 0.1f;
				}
				; break;
			case 'L':
				charL = Instantiate (LPrefab, transform.Find (behaelter), true);
				if (_title) {
					charL.transform.position = Vector3.right * versatz1;
					versatz1 += 0.1f;
				} else {
					charL.transform.position = Vector3.right * versatz2;
					charL.transform.Translate (Vector3.up * absatz);
					versatz2 += 0.1f;
				}
				; break;
			case 'm':
				charM = Instantiate (MPrefab, transform.Find (behaelter), true);
				if (_title) {
					charM.transform.position = Vector3.right * versatz1;
					versatz1 += 0.1f;
				} else {
					charM.transform.position = Vector3.right * versatz2;
					charM.transform.Translate (Vector3.up * absatz);
					versatz2 += 0.1f;
				}
				; break;
			case 'M':
				charM = Instantiate (MPrefab, transform.Find (behaelter), true);
				if (_title) {
					charM.transform.position = Vector3.right * versatz1;
					versatz1 += 0.1f;
				} else {
					charM.transform.position = Vector3.right * versatz2;
					charM.transform.Translate (Vector3.up * absatz);
					versatz2 += 0.1f;
				}
				; break;
			case 'n':
				charN = Instantiate (NPrefab, transform.Find (behaelter), true);
				if (_title) {
					charN.transform.position = Vector3.right * versatz1;
					versatz1 += 0.1f;
				} else {
					charN.transform.position = Vector3.right * versatz2;
					charN.transform.Translate (Vector3.up * absatz);
					versatz2 += 0.1f;
				}
				; break;
			case 'N':
				charN = Instantiate (NPrefab, transform.Find (behaelter), true);
				charN.transform.position = Vector3.right * versatz1;
				versatz1 += 0.1f;
				if (_title) {
					charN.transform.position = Vector3.right * versatz1;
					versatz1 += 0.1f;
				} else {
					charN.transform.position = Vector3.right * versatz2;
					charN.transform.Translate (Vector3.up * absatz);
					versatz2 += 0.1f;
				}
				; break;
			case 'o':
				charO = Instantiate (OPrefab, transform.Find (behaelter), true);
				if (_title) {
					charO.transform.position = Vector3.right * versatz1;
					versatz1 += 0.1f;
				} else {
					charO.transform.position = Vector3.right * versatz2;
					charO.transform.Translate (Vector3.up * absatz);
					versatz2 += 0.1f;
				}
				; break;
			case 'O':
				charO = Instantiate (OPrefab, transform.Find (behaelter), true);
				if (_title) {
					charO.transform.position = Vector3.right * versatz1;
					versatz1 += 0.1f;
				} else {
					charO.transform.position = Vector3.right * versatz2;
					charO.transform.Translate (Vector3.up * absatz);
					versatz2 += 0.1f;
				}
				; break;
			case 'p':
				charP = Instantiate (PPrefab, transform.Find (behaelter), true);
				if (_title) {
					charP.transform.position = Vector3.right * versatz1;
					versatz1 += 0.1f;
				} else {
					charP.transform.position = Vector3.right * versatz2;
					charP.transform.Translate (Vector3.up * absatz);
					versatz2 += 0.1f;
				}
				; break;
			case 'P':
				charP = Instantiate (PPrefab, transform.Find (behaelter), true);
				if (_title) {
					charP.transform.position = Vector3.right * versatz1;
					versatz1 += 0.1f;
				} else {
					charP.transform.position = Vector3.right * versatz2;
					charP.transform.Translate (Vector3.up * absatz);
					versatz2 += 0.1f;
				}
				; break;
			case 'q':
				charQ = Instantiate (QPrefab, transform.Find (behaelter), true);
				if (_title) {
					charQ.transform.position = Vector3.right * versatz1;
					versatz1 += 0.1f;
				} else {
					charQ.transform.position = Vector3.right * versatz2;
					charQ.transform.Translate (Vector3.up * absatz);
					versatz2 += 0.1f;
				}
				; break;
			case 'Q':
				charQ = Instantiate (QPrefab, transform.Find (behaelter), true);
				if (_title) {
					charQ.transform.position = Vector3.right * versatz1;
					versatz1 += 0.1f;
				} else {
					charQ.transform.position = Vector3.right * versatz2;
					charQ.transform.Translate (Vector3.up * absatz);
					versatz2 += 0.1f;
				}
				; break;
			case 'r':
				charR = Instantiate (RPrefab, transform.Find (behaelter), true);
				if (_title) {
					charR.transform.position = Vector3.right * versatz1;
					versatz1 += 0.1f;
				} else {
					charR.transform.position = Vector3.right * versatz2;
					charR.transform.Translate (Vector3.up * absatz);
					versatz2 += 0.1f;
				}
				; break;
			case 'R':
				charR = Instantiate (RPrefab, transform.Find (behaelter), true);
				if (_title) {
					charR.transform.position = Vector3.right * versatz1;
					versatz1 += 0.1f;
				} else {
					charR.transform.position = Vector3.right * versatz2;
					charR.transform.Translate (Vector3.up * absatz);
					versatz2 += 0.1f;
				}
				; break;
			case 's':
				charS = Instantiate (SPrefab, transform.Find (behaelter), true);
				if (_title) {
					charS.transform.position = Vector3.right * versatz1;
					versatz1 += 0.1f;
				} else {
					charS.transform.position = Vector3.right * versatz2;
					charS.transform.Translate (Vector3.up * absatz);
					versatz2 += 0.1f;
				}
				; break;
			case 'S':
				charS = Instantiate (SPrefab, transform.Find (behaelter), true);
				if (_title) {
					charS.transform.position = Vector3.right * versatz1;
					versatz1 += 0.1f;
				} else {
					charS.transform.position = Vector3.right * versatz2;
					charS.transform.Translate (Vector3.up * absatz);
					versatz2 += 0.1f;
				}
				; break;
			case 't':
				charT = Instantiate (TPrefab, transform.Find (behaelter), true);
				if (_title) {
					charT.transform.position = Vector3.right * versatz1;
					versatz1 += 0.1f;
				} else {
					charT.transform.position = Vector3.right * versatz2;
					charT.transform.Translate (Vector3.up * absatz);
					versatz2 += 0.1f;
				}
				; break;
			case 'T':
				charT = Instantiate (TPrefab, transform.Find (behaelter), true);
				if (_title) {
					charT.transform.position = Vector3.right * versatz1;
					versatz1 += 0.1f;
				} else {
					charT.transform.position = Vector3.right * versatz2;
					charT.transform.Translate (Vector3.up * absatz);
					versatz2 += 0.1f;
				}
				; break;
			case 'u':
				charU = Instantiate (UPrefab, transform.Find (behaelter), true);
				if (_title) {
					charU.transform.position = Vector3.right * versatz1;
					versatz1 += 0.1f;
				} else {
					charU.transform.position = Vector3.right * versatz2;
					charU.transform.Translate (Vector3.up * absatz);
					versatz2 += 0.1f;
				}
				; break;
			case 'U':
				charU = Instantiate (UPrefab, transform.Find (behaelter), true);
				if (_title) {
					charU.transform.position = Vector3.right * versatz1;
					versatz1 += 0.1f;
				} else {
					charU.transform.position = Vector3.right * versatz2;
					charU.transform.Translate (Vector3.up * absatz);
					versatz2 += 0.1f;
				}
				; break;
			case 'v':
				charV = Instantiate (VPrefab, transform.Find (behaelter), true);
				if (_title) {
					charV.transform.position = Vector3.right * versatz1;
					versatz1 += 0.1f;
				} else {
					charV.transform.position = Vector3.right * versatz2;
					charV.transform.Translate (Vector3.up * absatz);
					versatz2 += 0.1f;
				}
				; break;
			case 'V':
				charV = Instantiate (VPrefab, transform.Find (behaelter), true);
				if (_title) {
					charV.transform.position = Vector3.right * versatz1;
					versatz1 += 0.1f;
				} else {
					charV.transform.position = Vector3.right * versatz2;
					charV.transform.Translate (Vector3.up * absatz);
					versatz2 += 0.1f;
				}
				; break;
			case 'w':
				charW = Instantiate (WPrefab, transform.Find (behaelter), true);
				if (_title) {
					charW.transform.position = Vector3.right * versatz1;
					versatz1 += 0.1f;
				} else {
					charW.transform.position = Vector3.right * versatz2;
					charW.transform.Translate (Vector3.up * absatz);
					versatz2 += 0.1f;
				}
				; break;
			case 'W':
				charW = Instantiate (WPrefab, transform.Find (behaelter), true);
				if (_title) {
					charW.transform.position = Vector3.right * versatz1;
					versatz1 += 0.1f;
				} else {
					charW.transform.position = Vector3.right * versatz2;
					charW.transform.Translate (Vector3.up * absatz);
					versatz2 += 0.1f;
				}
				; break;
			case 'x':
				charX = Instantiate (XPrefab, transform.Find (behaelter), true);
				if (_title) {
					charX.transform.position = Vector3.right * versatz1;
					versatz1 += 0.1f;
				} else {
					charX.transform.position = Vector3.right * versatz2;
					charX.transform.Translate (Vector3.up * absatz);
					versatz2 += 0.1f;
				}
				; break;
			case 'X':
				charX = Instantiate (XPrefab, transform.Find (behaelter), true);
				if (_title) {
					charX.transform.position = Vector3.right * versatz1;
					versatz1 += 0.1f;
				} else {
					charX.transform.position = Vector3.right * versatz2;
					charX.transform.Translate (Vector3.up * absatz);
					versatz2 += 0.1f;
				}
				; break;
			case 'y':
				charY = Instantiate (YPrefab, transform.Find (behaelter), true);
				if (_title) {
					charY.transform.position = Vector3.right * versatz1;
					versatz1 += 0.1f;
				} else {
					charY.transform.position = Vector3.right * versatz2;
					charY.transform.Translate (Vector3.up * absatz);
					versatz2 += 0.1f;
				}
				; break;
			case 'Y':
				charY = Instantiate (YPrefab, transform.Find (behaelter), true);
				if (_title) {
					charY.transform.position = Vector3.right * versatz1;
					versatz1 += 0.1f;
				} else {
					charY.transform.position = Vector3.right * versatz2;
					charY.transform.Translate (Vector3.up * absatz);
					versatz2 += 0.1f;
				}
				; break;
			case 'z':
				charZ = Instantiate (ZPrefab, transform.Find (behaelter), true);
				if (_title) {
					charZ.transform.position = Vector3.right * versatz1;
					versatz1 += 0.1f;
				} else {
					charZ.transform.position = Vector3.right * versatz2;
					charZ.transform.Translate (Vector3.up * absatz);
					versatz2 += 0.1f;
				}
				; break;
			case 'Z':
				charZ = Instantiate (ZPrefab, transform.Find (behaelter), true);
				if (_title) {
					charZ.transform.position = Vector3.right * versatz1;
					versatz1 += 0.1f;
				} else {
					charZ.transform.position = Vector3.right * versatz2;
					charZ.transform.Translate (Vector3.up * absatz);
					versatz2 += 0.1f;
				}
				; break;
			case '-' : 
				charMinus = Instantiate (minusPrefab, transform.Find (behaelter), true);
				if (_title) {
					charMinus.transform.position = Vector3.right * versatz1;
					versatz1 += 0.1f;
				} else {
					charMinus.transform.position = Vector3.right * versatz2;
					charMinus.transform.Translate (Vector3.up * absatz);
					versatz2 += 0.1f;
				}
				; break;
			case ' ' : 
				versatz1 += 0.05f;
				; break;
			}
		}
		// setzten 
	}

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
