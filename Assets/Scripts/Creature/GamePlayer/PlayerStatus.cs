using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RogueLikeProject.Creature.GamePlayer
{
	public class PlayerStatus : CreatureStatus
	{
		override public void ApplyDamage(float damage)
		{
			hp -= damage;
		}
	}
}