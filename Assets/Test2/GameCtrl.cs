using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameCtrl : MonoBehaviour {

	public List<Charactor> ownCharactors = new List<Charactor>();

	public void Save(){

		SaveData.SetList ("ownCharactors", this.ownCharactors);

		SaveData.Save ();

	}

	public void Load(){
		
		ownCharactors = SaveData.GetList ("ownCharactors", new List<Charactor>());

		Debug.Log (this.ownCharactors[0].HP);
		Debug.Log (this.ownCharactors[1].HP);
		Debug.Log (this.ownCharactors[2].HP);
		Debug.Log (this.ownCharactors[3].HP);
		Debug.Log (this.ownCharactors[4].HP);
	}

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Q)) {
			Debug.Log ("Saved");
			this.Save ();
		}
		if (Input.GetKeyDown (KeyCode.E)) {
			Debug.Log ("Loaded");
			this.Load ();
		}
	}


}
