using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RogueLikeProject.Creature
{
	interface IDamageable
	{
		void ApplyDamage(float damage);
	}

	abstract public class CreatureStatus : IDamageable
	{
		protected float hp;
		protected float MaxHp;
		protected float mp;
		protected float MaxMp;

		protected float attackPower;
		protected float defensePower;


		public abstract void ApplyDamage(float damage);
	}
}