using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RogueLike.Character.Player
{
	public class PlayerMovement : MonoBehaviour
	{
		IInputProvider playerInput = new PlayerInputProvider();
		Vector3 targetPosition;

		[SerializeField]
		float movingSpeed = 1.0f;

		void Start()
		{
			targetPosition = this.transform.position;
		}


		void Update()
		{
			if (this.transform.position == targetPosition)
			{
				targetPosition += playerInput.InputDirection();
			}
			transform.position = Vector3.MoveTowards(transform.position, targetPosition, movingSpeed * Time.deltaTime);
		}
	}
}