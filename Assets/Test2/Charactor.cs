using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Charactor : MonoBehaviour {

	public string charactorId;
	public int HP;

	[System.Serializable]
	public class Character
	{
		public string charactorId;
		public int HP;

	}

	// Use this for initialization
	void Start () {
		
		Character charactor = new Character ();
		charactor.charactorId = this.charactorId;
		charactor.HP = this.HP;
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
