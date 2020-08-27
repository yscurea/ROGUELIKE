using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace RogueLikeProject.Character
{
	public class CharacterMovement : MonoBehaviour
	{
		protected CharacterPosition position;

		protected float moveSpeed = 5.0f;
		protected Vector3 targetPosition;
		protected Vector3 nowPosition;

		public void SetTargetPosition(Vector3 position)
		{
			targetPosition = position;
		}

	}
}