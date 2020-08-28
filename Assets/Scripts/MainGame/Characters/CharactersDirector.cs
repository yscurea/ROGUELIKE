using RogueLikeProject.Dungeon;
using RogueLikeProject.MyLib;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RogueLikeProject.Character
{
	public class CharactersDirector
	{
		int enemyNum = 0;
		int maxEnemyNum = 10;
		CharactersObject charactersObject;
		CharacterGenerator characterGenerator;
		public void Init()
		{
			// Instantiate player object

			// Instantiate enemy character
			while (maxEnemyNum > enemyNum)
			{
				characterGenerator.Instantiate();
			}
		}
		public void Update()
		{
			if (enemyNum < maxEnemyNum)
			{
				charactersObject.InstantiateCharacters();
			}
		}
	}
}