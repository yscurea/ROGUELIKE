using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RogueLikeProject.Character
{
	public class Player : Character
	{
		public override bool Act()
		{
			return false;
			// return true when the turn has passed.
		}

	}
}