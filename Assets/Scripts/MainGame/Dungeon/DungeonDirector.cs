using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RogueLikeProject.Dungeon
{
	public class DungeonDirector : MonoBehaviour
	{
		// Is dungeon size variabillity?
		public int dungeonZ { get; } = 30;
		public int dungeonX { get; } = 54;


		public static float sqareSize = 1.0f;

		Map.MapGenerator mapGenerator = new Map.MapGenerator();
		Map.MapObjectManager mapObjectManager = new Map.MapObjectManager();
		TerrainType[,] mainMap;
		Map.RoomDirector roomDirector;
		Map.MapInfoManager mapInfoManager = new Map.MapInfoManager();

		public void Init(int floorNumber)
		{
			/*
			first, generate dungeon_map;
				GenerateMap;
				Instantiate map_objects;
			second, generate character based on dungeon_map;
				Instantiate player;
				Instantiate others characters;
			*/


			// Depends on floorNumber
			roomDirector = new Map.RoomDirector();
			mainMap = mapGenerator.GenerateMap(roomDirector.rooms);

			mapObjectManager.Init();
			mapObjectManager.DungeonInstantiate(this.gameObject, mainMap);
		}

		public void Update()
		{
			/*
			check gameover;
			wait for player's input;
			if there were players input, players act and characters act after that;
			*/
		}

	}
}