﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {


	/*
	//プレイヤーの情報
	public Player player = new Player();
	//手持ちキャラクターの情報
	public List<Character> ownCharacters = new List<Character>();
	//バトルの情報
	public Battle battle = new Battle();
	//フラグ情報
	public GameFlags gameFlags = new GameFlags();
	//マスタデータ
	[SerializeField] private MasterData _MasterData;
	public MasterData masterData
	{
		get
		{
			if (_MasterData == null)
			{
				_MasterData = Resources.Load<Entity_Enemy>("ScriptableObjects/MasterData");
			}
			return _MasterData;
		}
	}

	//こうしておくとGameManager.instanceでGetComponentせずに取得できる
	public static GameManager instance;

	void Awake(){
		//GameManager.instanceでの取得用の初期化
		instance = this;
		//SceneをまたいでもGameObjectを残すため
		DontDestroyOnLoad(gameObject);
		//開発用にEditorでは毎回初期化する,念を入れてDebug.isDebugBuildもif条件に。
		#if UNITY_EDITOR
		if (Debug.isDebugBuild)
		{
			SaveData.Clear();
		}
		#endif
		//ロード処理
		Load();
	}

	public void Save()
	{
		Debug.Log("Save");
		//セーブデータの設定
		SaveData.SetClass("player", player);
		SaveData.SetList("ownCharacters", ownCharacters);
		SaveData.SetClass("gameFlags", gameFlags);
		SaveData.SetClass("battle", battle);
		//セーブ
		SaveData.Save();
	}

	public void Load()
	{
		Debug.Log("Load");
		//ロード
		player = SaveData.GetClass("player", new Player());
		ownCharacters = SaveData.GetList("ownCharacters", new List<Character>());
		gameFlags = SaveData.GetClass("gameFlags", new GameFlags());
		battle = SaveData.GetClass("battle", new Battle());

		//IDを元にMasterDataからScriptableObjectを取得し直す
		for (int i = 0; i < ownCharacters.Count; i++)
		{
			//キャラクターデータ
			var ch = ownCharacters[i];
			ch.data = masterData.characterDataTable[ch.dataId];
			//覚えているスキル
			ch.skills.Clear();
			for (int j = 0; j < ch.skillIds.Count; j++)
			{
				ch.skills.Add(masterData.skillBaseTable[skillIds[j]]);
			}
		}
	}

	*/
}