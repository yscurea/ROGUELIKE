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
		protected static Character[,] characters;
		protected CharacterStatus status;

		public static void InitCharacters(int z, int x)
		{
			characters = new Character[z, x];
		}
		public abstract bool Act();

	}

}