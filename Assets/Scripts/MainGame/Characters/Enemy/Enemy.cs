using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RogueLikeProject.Character
{
	public class Enemy : Character
	{
		override public bool Act()
		{
			// do something when the player acted

			this.nowAction = Action.ActStart;

			// decide what do something

			// do
			this.nowAction = Action.InAct;


			// end
			this.nowAction = Action.ActEnd;
			return true;
		}
	}
}
