using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RogueLikeProject.Character
{
	interface IDamageable
	{
		void ApplyDamage(float damage);
	}

	abstract public class CharacterStatus
	{
		protected float hp;
		protected float MaxHp;
		protected float mp;
		protected float MaxMp;

		protected float attackPower;
		protected float defensePower;

	}
}