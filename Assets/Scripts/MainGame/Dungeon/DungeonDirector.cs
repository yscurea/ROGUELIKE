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

		DungeonGenerator dungeonGenerator = new DungeonGenerator();
		DungeonObject dungeonObject = new DungeonObject();

		TerrainType[,] mainMap;
		RoomDirector roomDirector;


		public void Init(int floorNumber)
		{
			// Depends on floorNumber
			roomDirector = new RoomDirector();
			mainMap = dungeonGenerator.GenerateMap(roomDirector.rooms);

			dungeonObject.Init();
			dungeonObject.DungeonInstantiate(this.gameObject, mainMap);
		}

	}
}