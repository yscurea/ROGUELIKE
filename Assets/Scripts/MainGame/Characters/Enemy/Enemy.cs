using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RogueLikeProject.Character
{
	public abstract class Enemy : Character
	{
		public Enemy(Utils.Position position) : base(position)
		{
		}
	}
}
