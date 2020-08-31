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

		// give this mainMap information for each characters
		Object[,,] mainMap;
		Map.RoomDirector roomDirector;

		// multiple player?
		Player player;
		Enemy[] enemies;
		public void Init(Object[,,] refMap, Map.RoomDirector refRoomDirector)
		{
			this.mainMap = refMap;
			this.roomDirector = refRoomDirector;

			// Instantiate player object
			player = new Player(this.GetSpawnRandomPosition());

			// Instantiate enemy character maxEnemyNum times;
			while (enemyNum < maxEnemyNum)
			{
				this.SpawnEnemy();
				enemyNum++;
			}
		}
		public void Update()
		{
			if (enemyNum < maxEnemyNum)
			{
			}
			player.Act();
			foreach (Enemy enemy in enemies)
			{
				enemy.Act();
			}
		}


		Utils.Position GetSpawnRandomPosition()
		{
			Utils.Coordinate crd = roomDirector.GetRandomCoordinate();
			return new Utils.Position() { coordinate = crd, layer = Utils.Layer.Character };
		}

		void SpawnEnemy()
		{

		}
	}
}