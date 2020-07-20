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

		[SerializeField]
		DungeonGenerator dungeonGenerator;
		DungeonObject dungeonObject;

		RoomDirector roomDirector = new RoomDirector();

		// 初期化を行う．再生成ではない
		public void InitDungeon(int floorNumber)
		{
			// floorNumberの値で出てくるキャラクターを変更する?
			dungeonGenerator = new DungeonGenerator(dungeonZ, dungeonX);
			if (dungeonObject is null)
			{
				dungeonObject = GetComponent<DungeonObject>();
			}
			dungeonObject.DungeonInstantiate(dungeonGenerator.GenerateMap());
		}

		// 部屋のランダムな座標を得る．通路の座標は返さない
		public Coordinate GetRandomCoordinate()
		{
			Coordinate tmp = new Coordinate { x = 0, z = 0 };
			return tmp;
		}
	}
}