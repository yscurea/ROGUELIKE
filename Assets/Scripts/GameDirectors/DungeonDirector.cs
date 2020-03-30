using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace RogueLikeProject.GameDirector
{
	public class DungeonDirector : MonoBehaviour
	{
		private static int hierarchy = 0;

		[SerializeField]
		Dungeon.DungeonGenerator dungeonGenerator;
		[SerializeField]
		Dungeon.DungeonInstantiation dungeonInstantiation;


		void Start()
		{
			InitDungeon();
		}

		private void InitDungeon()
		{
			int dungeonZ, dungeonX;
			(dungeonZ, dungeonX) = dungeonGenerator.GetDungeonSize();
			dungeonGenerator = new Dungeon.DungeonGenerator(dungeonZ, dungeonX);

			Creature.CreaturePosition.InitCreaturesPosition(dungeonZ, dungeonX);
			item.ItemPosition.InitItemsPosition(dungeonZ, dungeonX);
		}




	}
}