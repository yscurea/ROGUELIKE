using RogueLikeProject.Dungeon;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using RogueLikeProject.Utils;

namespace RogueLikeProject.Character
{
	public class CharactersManager
	{
		int enemyNum = 0;
		int maxEnemyNum = 10;
		CharactersObject charactersObject;
		CharacterGenerator characterGenerator;

		Enemy[] enemies;
		public void Init(TerrainType[,] mapInfo)
		{
			// Instantiate player object

			// Instantiate enemy character
			while (maxEnemyNum > enemyNum)
			{
				characterGenerator.InstantiateCharacter();
			}
		}
		public void Update()
		{
			if (enemyNum < maxEnemyNum)
			{
				charactersObject.InstantiateCharacters();
			}
		}

		void SpawnCharacters()
		{

		}
	}
}