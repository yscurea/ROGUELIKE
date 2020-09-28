using UnityEngine;

namespace RogueLike.Managers
{
	public class DungeonManager : MonoBehaviour
	{
		int floorNum = 1;
		TurnManager turnManager;
		StageManager stageManager;
		CharactersManager charactersManager;

		void Start()
		{
			print("Start");
			this.InitializeStage(this.floorNum);
		}
		void Update()
		{
			// Update Dungeon
			this.turnManager.Update();

			// characters update
			charactersManager.UpdateCharacters();
		}

		// publish it for the time being.
		public void InitializeStage(int floorNum)
		{
			//DI
			this.stageManager = new StageManager();
			this.charactersManager = new CharactersManager(this.stageManager.GetStageTerrainProvider());
			this.turnManager = new TurnManager();


			// init stage
			this.stageManager.GenerateStage(floorNum);

			// init characters
			this.charactersManager.InitializeCharacters(floorNum);

			this.floorNum++;
		}
	}
}