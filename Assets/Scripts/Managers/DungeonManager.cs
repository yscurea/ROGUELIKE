using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RogueLike.Managers
{
	public class DungeonManager : MonoBehaviour
	{
		StageManager stageManager;

		void Update()
		{
			// Update Dungeon
		}

		public void InitStage(int floorNum)
		{
			// init stage
			this.stageManager.GenerateStage();

			// init player

			// init characters
		}
	}
}