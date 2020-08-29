using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RogueLikeProject.Character
{
	interface IDamageable
	{
		void ApplyDamage(float damage);
	}

	public class CharacterStatus
	{
		protected float MaxHp;
		protected float hp;
		protected float MaxMp;
		protected float mp;

		protected float attackPower;
		protected float defensePower;

	}
}