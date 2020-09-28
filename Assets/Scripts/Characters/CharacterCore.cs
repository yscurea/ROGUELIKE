using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RogueLike.Characters
{
	public abstract class CharacterCore
	{
		protected Utils.ID iD;
		protected ActionState state;
		public abstract ActionState StartBehave();
	}
}