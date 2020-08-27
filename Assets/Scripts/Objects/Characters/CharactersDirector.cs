using RogueLikeProject.Dungeon;
using RogueLikeProject.MyLib;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RogueLikeProject.Character
{
	public class CharactersDirector : MonoBehaviour
	{
		int enemyNum = 0;
		int maxEnemyNum = 10;
		CharactersObject charactersObject;
		CharacterGenerator characterGenerator;
		DungeonDirector dungeonDirector;
		public void Init()
		{
		}
		void GenerateCharacter(GameObject character)
		{

			enemyNum++;
		}
	}
}