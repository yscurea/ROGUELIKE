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
		public void InitCharacters()
		{
			charactersObject = GetComponent<CharactersObject>();
		}
		void GenerateCharacter(GameObject character)
		{

			enemyNum++;
		}
		public void Input()
		{

		}
	}
}