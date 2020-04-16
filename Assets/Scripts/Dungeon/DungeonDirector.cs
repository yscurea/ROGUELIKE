using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RogueLikeProject.Dungeon
{
	public class DungeonDirector : MonoBehaviour
	{
		public static float sqareSize = 1.0f;
		private static int hierarchy = 0;

		[SerializeField]
		DungeonInstantiation dungeonInstantiation;
		[SerializeField]
		DungeonGenerator dungeonGenerator;
		[SerializeField]
		Creature.CreaturesManager creaturesManager;

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
			int dungeonZ, dungeonX;
			(dungeonZ, dungeonX) = dungeonGenerator.GetDungeonSize();
			dungeonGenerator = new DungeonGenerator(dungeonZ, dungeonX,ref this.roomDirector);
			dungeonInstantiation.DungeonInstantiate(dungeonGenerator.GenerateMap(), this.gameObject);

			Creature.CreaturePosition.InitCreaturesPosition(dungeonZ, dungeonX);
			item.ItemPosition.InitItemsPosition(dungeonZ, dungeonX);

			//playerの生成
			creaturesManager.InstantiateCreatures(this.roomDirector);
			//アイテムの生成
		}




	}
}