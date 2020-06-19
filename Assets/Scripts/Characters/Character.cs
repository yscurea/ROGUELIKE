using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RogueLikeProject.Character
{
	public enum Action
	{

	}


	public abstract class Character
	{
		protected CharacterStatus status;

		public abstract bool Act();

	}

}