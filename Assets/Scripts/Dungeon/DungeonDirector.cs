using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RogueLikeProject.Dungeon
{
	public class DungeonDirector : MonoBehaviour
	{
		[SerializeField]
		private int dungeonZ = 30;
		[SerializeField]
		private int dungeonX = 54;

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
	}
}