using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RogueLikeProject.Character
{
	public enum Action
	{
		Idling,
		ActStart,
		InAct,
		ActEnd
	}

	public abstract class Character : RogueLikeProject.Object.Object
	{
		protected Action nowAction = Action.Idling;
		protected static Character[,] characters;
		protected CharacterPosition position;
		protected CharacterStatus status;
		public static void InitCharacters(int z, int x)
		{
			characters = new Character[z, x];
		}
		public abstract bool Act();
	}
}