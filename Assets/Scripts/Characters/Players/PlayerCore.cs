using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace RogueLike.Characters.Player
{
	public class PlayerCore : CharacterCore
	{
		public override RogueLike.Characters.ActionState StartBehave()
		{
			Debug.Log("player behave");
			this.state = ActionState.StartMove;
			return this.state;
		}
	}
}