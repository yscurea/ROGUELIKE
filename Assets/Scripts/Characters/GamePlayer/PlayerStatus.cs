using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RogueLikeProject.Character.GamePlayer
{
	public class PlayerStatus : CharacterStatus
	{
		override public void ApplyDamage(float damage)
		{
			hp -= damage;
		}
	}
}