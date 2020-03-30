using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace RogueLikeProject.GameDirector
{
	public class DungeonDirector : MonoBehaviour
	{
		private static int hierarchy = 0;


		//DungeonPosition --|> each position
		//DungeonPosition{ static protected dungeon(X and Y) }
		[SerializeField]
		private int dungeonX;
		[SerializeField]
		private int dungeonZ;

		[SerializeField]
		Dungeon.DungeonGenerator dungeonGenerator;

		void Start()
		{
			InitDungeon();

			//generate dungeon
			//generate creature
		}

		private void InitDungeon()
		{
			dungeonGenerator = new Dungeon.DungeonGenerator(dungeonZ, dungeonX);

			Creature.CreaturePosition.InitCreaturesPosition(dungeonZ, dungeonX);
			item.ItemPosition.InitItemsPosition(dungeonZ, dungeonX);
		}




	}
}