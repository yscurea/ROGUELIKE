namespace RogueLike.Managers
{
	public class StageManager
	{
		Stage.StageTerrainProvider stageTerrainProvider;
		Stage.IStageGenerator stageGenerator = new Stage.AutoStageGenerator();


		public void GenerateStage(int floorNum)
		{
			UnityEngine.Debug.Log("generate stage");
			stageGenerator.GenerateStage();
		}

		public Stage.StageTerrainProvider GetStageTerrainProvider()
		{
			return this.stageTerrainProvider;
		}
	}
}