namespace RogueLike.Managers
{
	public class TurnLimit
	{
		TurnManager turnManager;
		int turnLimitNum = 1000;
		int turnNum = 0;
		public TurnLimit(TurnManager turnManager, int limit)
		{
			this.turnManager = turnManager;
			this.turnLimitNum = limit;
		}

		public void IncrementTurnNum()
		{
			this.turnNum++;
			if (this.turnLimitNum == this.turnNum)
			{
				this.turnManager.TurnLimit();
			}
		}
	}
}