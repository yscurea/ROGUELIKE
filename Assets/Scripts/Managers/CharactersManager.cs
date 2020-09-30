namespace RogueLike.Managers
{
	public class CharactersManager
	{
		Stage.StageTerrainProvider stageTerrainProvider;

		public CharactersManager(Stage.StageTerrainProvider stageTerrainProvider)
		{
			this.stageTerrainProvider = stageTerrainProvider;
		}

		public void InitializeCharacters(int floorNum)
		{
			UnityEngine.Debug.Log("charactersManager init");
			if (floorNum == 1)
			{
				Characters.Player.PlayerCore playerCore = new Characters.Player.PlayerCore();
			}
		}

		public void UpdateCharacters()
		{

		}
	}

}