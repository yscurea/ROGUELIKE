using RogueLikeProject.Character;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.SceneManagement;

// ここが実際のゲームプレイ中の画面のスクリプトを全て制御する
namespace RogueLikeProject.Dungeon
{
	public class PlayViewDirector : MonoBehaviour
	{
		CharactersDirector characterDirector;
		DungeonDirector dungeonDirector;
		Player player;

		private int floorNumber = 1;

		void Start()
		{
			dungeonDirector = this.transform.Find("DungeonDirector").gameObject.GetComponent<DungeonDirector>();
			characterDirector = this.transform.Find("CharactersDirector").gameObject.GetComponent<CharactersDirector>();

			dungeonDirector.InitDungeon(floorNumber);
			characterDirector.Init();
		}
		void Update()
		{
			JudgeGameEnd();
			// characterDirector.キャラ操作の全ての処理をここで
		}


		void JudgeGameEnd()
		{
			/*
			if (//playerが操作不能状態(HP0etc)になったら)
			{
				SceneManager.LoadScene("deadScene");
			}
			if (//playerがゴールしたら)
			{
				SceneManager.LoadScene("resultScene");
			}
			/**/
		}
	}
}
