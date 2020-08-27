using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.SceneManagement;

using RogueLikeProject.Character;
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

			dungeonDirector.Init(floorNumber);
			characterDirector.Init();
		}
		void Update()
		{
			characterDirector.Update();
			dungeonDirector.Update();
		}

	}
}
