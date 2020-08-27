using RogueLikeProject.MyLib;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RogueLikeProject.Dungeon
{
	public class DungeonDirector : MonoBehaviour
	{
		// ダンジョンのサイズ可変にする?
		public int dungeonZ { get; } = 30;
		public int dungeonX { get; } = 54;

		public static float sqareSize = 1.0f;

		DungeonGenerator dungeonGenerator = new DungeonGenerator();
		DungeonObject dungeonObject;

		TerrainType[,] mainMap;
		RoomDirector roomDirector;


		public void InitDungeon(int floorNumber)
		{
			// floorNumberの値で出てくるキャラクターを変更する?
			dungeonObject = GetComponent<DungeonObject>();
			roomDirector = new RoomDirector();
			mainMap = dungeonGenerator.GenerateMap(roomDirector.rooms);
			dungeonObject.DungeonInstantiate(mainMap);
		}
	}
}