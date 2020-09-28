using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace RogueLike.Characters.Player
{
	public class PlayerCore : CharacterCore
	{
		public override RogueLike.Characters.ActionState StartBehave()
		{
			this.state = ActionState.StartMove;
			return this.state;
		}
	}
}