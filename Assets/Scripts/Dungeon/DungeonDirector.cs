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

		public static float sqareSize = 1.0f;
		private static int hierarchy = 0;

		[SerializeField]
		DungeonGenerator dungeonGenerator;
		[SerializeField]
		DungeonInstantiation dungeonInstantiation;

		RoomDirector roomDirector = new RoomDirector();

		void Start()
		{
			InitDungeon();
		}

		void Update()
		{
			//playerの入力待ち
			//playerの行動
			//敵の行動
		}

		private void InitDungeon()
		{
			dungeonGenerator = new DungeonGenerator(dungeonZ, dungeonX,ref roomDirector);
			dungeonInstantiation = new DungeonInstantiation(dungeonGenerator.GenerateMap(), this.gameObject);

			Creature.CreaturePosition.InitCreaturesPosition(dungeonZ, dungeonX);
			item.ItemPosition.InitItemsPosition(dungeonZ, dungeonX);
		}




	}
}