using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RogueLikeProject.Dungeon
{
	[DefaultExecutionOrder(-1)]
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
		DungeonInstantiation dungeonInstantiation;

		private void Start()
		{
			dungeonInstantiation = this.transform.GetChild(0).GetComponent<DungeonInstantiation>();
			if (dungeonInstantiation == null)
			{
				Debug.Log("dungeonInstantioation is null");
			}
		}
		public void InitDungeon(int floorNumber)
		{
			// floorNumberの値で出てくるキャラクターを変更する
			dungeonGenerator = new DungeonGenerator(dungeonZ, dungeonX);
			if (dungeonInstantiation == null)
			{
				Debug.Log("is null");
				dungeonInstantiation = this.transform.GetChild(0).GetComponent<DungeonInstantiation>();
			}
			dungeonInstantiation.DungeonInstantiate(dungeonGenerator.GenerateMap(), this.gameObject);
		}
	}
}