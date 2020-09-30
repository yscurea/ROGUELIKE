namespace RogueLike.Managers
{
	public class TurnManager
	{
		TurnLimit turnLimit;
		CharactersTurnManager charactersTurnManager;
		public void Init()
		{
		}

		public void Update()
		{
			charactersTurnManager.UpdateCharactersTurn();
		}

		public void TurnLimit()
		{
		}
	}
}