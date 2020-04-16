using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace RogueLikeProject.Creature
{
	public class CreatureMovement : MonoBehaviour
	{
		protected CreaturePosition position;

		protected float moveSpeed = 5.0f;
		protected Vector3 targetPosition;
		protected Vector3 nowPosition;

		protected void Start()
		{
			position = GetComponent<CreaturePosition>();

			MyLib.Coordinate tmp = position.GetPosition();

			nowPosition = new Vector3(
				tmp.x * Dungeon.DungeonDirector.sqareSize,
				0,
				tmp.z * Dungeon.DungeonDirector.sqareSize
			);
			targetPosition = nowPosition;
		}

		public void SetTargetPosition(Vector3 position)
		{
			targetPosition = position;
		}

	}
}