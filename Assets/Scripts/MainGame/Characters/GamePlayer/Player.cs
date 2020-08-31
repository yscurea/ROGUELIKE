using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RogueLikeProject.Character
{
	// abstract? multiple character?
	public class Player : Character
	{
		public Player(Utils.Position position) : base(position)
		{

		}

		public override bool Act()
		{
			// return true when the turn has passed.
			return false;
		}

		protected override void LoadEntity()
		{
			// this.entity = Resources.Load<GameObject>("");
		}
	}
}