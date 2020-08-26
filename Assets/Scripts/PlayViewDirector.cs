using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.SceneManagement;

using RogueLikeProject.Character;
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
			// 検討:MonoBehaviourの継承の必要性がない
			dungeonDirector = this.transform.Find("DungeonDirector").gameObject.GetComponent<DungeonDirector>();
			characterDirector = this.transform.Find("CharactersDirector").gameObject.GetComponent<CharactersDirector>();

			dungeonDirector.InitDungeon(floorNumber);
			characterDirector.InitCharacters();
		}
		void Update()
		{
			JudgeGameEnd();
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
			// 次のステージへの遷移はシーン再読み込み、もしくはパラメータ保持の関係で画面暗転再初期化
			/**/
		}
	}
}
