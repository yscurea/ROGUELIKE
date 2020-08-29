using RogueLikeProject.Dungeon;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RogueLikeProject.Character
{
	public class CharactersManager
	{
		int enemyNum = 0;
		int maxEnemyNum = 10;
		CharacterGenerator characterGenerator = new CharacterGenerator();

		Enemy[] enemies;
		public void Init(TerrainType[,] mapInfo)
		{
			// Instantiate player object

			// Instantiate enemy character maxEnemyNum times;
		}
		public void Update()
		{
			if (enemyNum < maxEnemyNum)
			{
			}
		}

		void SpawnCharacters()
		{

		}
	}
}