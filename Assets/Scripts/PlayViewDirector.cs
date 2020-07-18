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
		//Scene deadScene;
		//Scene completeScene;
		CharactersDirector characterDirector;
		Player player;
		DungeonDirector dungeonDirector;

		private int floorNumber = 1;

		private void Start()
		{
			dungeonDirector = this.transform.Find("DungeonDirector").gameObject.GetComponent<DungeonDirector>();
			characterDirector = this.transform.Find("CharactersDirector").gameObject.GetComponent<CharactersDirector>();

			dungeonDirector.InitDungeon(floorNumber);
			characterDirector.Init();
		}
		private void Update()
		{
			/*
			if (player.isDead())
			{
				// 死亡画面に遷移
			}
			if (player.transitionNextFloor())
			{
				// 次のマップ生成
			}
			*/
		}
	}
}
