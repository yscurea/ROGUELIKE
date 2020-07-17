using RogueLikeProject.MyLib;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RogueLikeProject.Dungeon
{
	public class DungeonDirector : MonoBehaviour
	{
		[SerializeField]
		public int dungeonZ { get; } = 30;
		public int dungeonX { get; } = 54;

		//定義場所を再考する
		public static float sqareSize = 1.0f;

		[SerializeField]
		DungeonGenerator dungeonGenerator;
		DungeonObject dungeonObject;

		public void InitDungeon(int floorNumber)
		{
			// floorNumberの値で出てくるキャラクターを変更する
			dungeonGenerator = new DungeonGenerator(dungeonZ, dungeonX);
			if (dungeonObject is null)
			{
				dungeonObject = GetComponent<DungeonObject>();
			}
			dungeonObject.DungeonInstantiate(dungeonGenerator.GenerateMap());
		}

		public Coordinate GetRandomCoordinate()
		{
			Coordinate tmp = new Coordinate { x = 0, z = 0 };
			return tmp;
		}
	}
}