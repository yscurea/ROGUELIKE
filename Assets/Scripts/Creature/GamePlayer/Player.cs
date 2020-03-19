using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RogueLikeProject.Creature.GamePlayer
{
	public class Player : Creature
	{
		private void Start()
		{
			status = new PlayerStatus();
		}
	}
}