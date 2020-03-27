using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace RogueLikeProject.GameDirector
{
	public class DungeonDirector : MonoBehaviour
	{
		[SerializeField]
		private int dungeonX;
		[SerializeField]
		private int dungeonZ;

		void Start()
		{
			Creature.CreaturePosition.creaturePositions = new Creature.CreaturePosition[dungeonZ, dungeonX];
			item.ItemPosition.itemPositions = new item.ItemPosition[dungeonZ, dungeonX];

			//generate dungeon
			//generate creature
		}
	}
}