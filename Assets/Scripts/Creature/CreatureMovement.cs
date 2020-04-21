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

		public void SetTargetPosition(Vector3 position)
		{
			targetPosition = position;
		}

	}
}