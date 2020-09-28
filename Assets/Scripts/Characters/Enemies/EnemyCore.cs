namespace RogueLike.Characters.Enemy
{
	public class EnemyCore : CharacterCore
	{
		public override ActionState StartBehave()
		{
			return ActionState.StartMove;
		}

		public ActionState ActionDecision()
		{
			return ActionState.StartMove;
		}
	}
}