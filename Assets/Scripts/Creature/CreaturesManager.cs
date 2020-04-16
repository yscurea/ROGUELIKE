using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace RogueLikeProject.Creature
{
	[System.Serializable]
	public class CreaturesManager
	{
		[SerializeField]
		GameObject playerObject;
		List<Creature> creatures = new List<Creature>();

		public void InstantiateCreatures(Dungeon.RoomDirector roomDirector)
		{
			MyLib.Coordinate coordinate = roomDirector.GetRandomCoordinate();
			Vector3 position = new Vector3(
				coordinate.x * Dungeon.DungeonDirector.sqareSize,
				0,
				coordinate.z * Dungeon.DungeonDirector.sqareSize
				);
			GameObject.Instantiate(playerObject, position, Quaternion.identity);


		}

	}
}