using RogueLikeProject.MyLib;
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

		public void Init(int floorNumber)
		{
			// Depends on floorNumber
			roomDirector = new Map.RoomDirector();
			mainMap = mapGenerator.GenerateMap(roomDirector.rooms);

			mapObjectManager.Init();
			mapObjectManager.DungeonInstantiate(this.gameObject, mainMap);
			const int x = 10;
			Debug.Log("xxx");
		}

		public void Update()
		{
		}

	}
}