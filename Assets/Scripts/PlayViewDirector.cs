using RogueLikeProject.Character;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.SceneManagement;

// ここが実際のゲームプレイ中の画面のスクリプトを全て制御する
namespace RogueLikeProject.Dungeon
{
	[DefaultExecutionOrder(-1)]
	public class PlayViewDirector : MonoBehaviour
	{
		//Scene deadScene;
		//Scene completeScene;
		CharacterDirector characterDirector;
		Player player;
		DungeonDirector dungeonDirector;

		private int floorNumber = 1;

		private void Start()
		{
			dungeonDirector = transform.GetChild(0).gameObject.GetComponent<DungeonDirector>();
			if (dungeonDirector is null)
			{
				Debug.Log("null");
			}
			this.GenerateMap();
			//InitCharacter();
			//player = CharacterDirector.GetPlayer();
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

		private void GenerateMap()
		{
			dungeonDirector.InitDungeon(++floorNumber);

			//characterDirector.InitPosition(dungeonDirector.getDungeonInfo);
		}
	}
}
