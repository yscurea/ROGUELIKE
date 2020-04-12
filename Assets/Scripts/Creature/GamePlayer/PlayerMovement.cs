using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace RogueLikeProject.Creature.GamePlayer
{
	public class PlayerMovement : CreatureMovement
	{
		float inputVertical;
		float inputHorizontal;
		float inputThreshold = 0.15f;

		private void Update()
		{
			if (this.transform.position == targetPosition)
			{
				inputVertical = Input.GetAxis("Vertical");
				inputHorizontal = Input.GetAxis("Horizontal");
			}
			else
			{
				inputVertical = 0.0f;
				inputHorizontal = 0.0f;
			}
			CheckInput();
		}
		private void FixedUpdate()
		{
			UpdatePosition();
		}

		private void UpdatePosition()
		{
			transform.position = Vector3.MoveTowards(
				transform.position,
				targetPosition,
				moveSpeed * Time.deltaTime
			);
		}

		private void CheckInput()
		{
			if (inputHorizontal > inputThreshold)
			{
				targetPosition.x += Dungeon.DungeonDirector.sqareSize;
				if (inputVertical > inputThreshold)
				{
					targetPosition.z += Dungeon.DungeonDirector.sqareSize;
				}
				else if (inputVertical < -inputThreshold)
				{
					targetPosition.z -= Dungeon.DungeonDirector.sqareSize;
				}
			}
			else if (inputHorizontal < -inputThreshold)
			{
				targetPosition.x -= Dungeon.DungeonDirector.sqareSize;
				if (inputVertical > inputThreshold)
				{
					targetPosition.z += Dungeon.DungeonDirector.sqareSize;
				}
				else if (inputVertical < -inputThreshold)
				{
					targetPosition.z -= Dungeon.DungeonDirector.sqareSize;
				}
			}
			else
			{
				if (inputVertical > inputThreshold)
				{
					targetPosition.z += Dungeon.DungeonDirector.sqareSize;
				}
				else if (inputVertical < -inputThreshold)
				{
					targetPosition.z -= Dungeon.DungeonDirector.sqareSize;
				}
			}
		}


	}
}