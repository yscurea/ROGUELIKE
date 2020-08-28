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
		CharactersDirector characterDirector = new CharactersDirector();
		DungeonDirector dungeonDirector = new DungeonDirector();
		private int floorNumber = 1;

		void Start()
		{
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
