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

	public abstract class Character : RogueLikeProject.Object
	{
		// animation controll
		protected Action nowAction = Action.Idling;
		protected CharacterStatus status;
		public abstract bool Act();
	}
}