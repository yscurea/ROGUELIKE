using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RogueLikeProject.Character
{
	public class Player : Character
	{
		public override bool Act()
		{
			//ターンが経過しない行動をしたときは
			//return false;
			//ターンが経過する行動をしたときに
			return true;
		}

	}
}