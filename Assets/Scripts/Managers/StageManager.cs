using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RogueLike.Managers
{
	public class StageManager
	{
		Stage.StageTerrainProvider stageTerrainProvider;
		Stage.IStageGenerator stageGenerator;


		public void GenerateStage()
		{
			stageGenerator.GenerateStage();
		}

		public Stage.StageTerrainProvider GetStageTerrainProvider()
		{
			return this.stageTerrainProvider;
		}
	}
}