using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RogueLikeProject.Creature
{
	public enum Action
	{
		
	}


	public abstract class Creature
	{
		protected CreatureStatus status;

		public abstract bool Act();

	}

}