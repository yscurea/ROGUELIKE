using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace RogueLikeProject.Creature.GamePlayer
{
	public class PlayerMovement : CreatureMovement
	{
		float targetPosition;
		float nowPosition;

		float inputVertical;
		float inputHorizontal;
		float inputThreshold = 0.3f;

		private void Start()
		{

		}
		private void Update()
		{
			if (nowPosition == targetPosition)
			{
				inputVertical = Input.GetAxis("Vertical");
				inputHorizontal = Input.GetAxis("Horizontal");
			}
			else
			{
				inputVertical = 0.0f;
				inputHorizontal = 0.0f;
			}
		}
		private void FixedUpdate()
		{
			if (inputHorizontal > inputThreshold && inputVertical > inputThreshold)
			{

			}
			//else if(inputHorizontal> inputThreshold && inputVertical)
		}



	}
}