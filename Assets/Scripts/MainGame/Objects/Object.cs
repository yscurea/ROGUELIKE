using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RogueLikeProject
{

	public abstract class Object
	{
		// define here for  common functions.
		protected static Object[,,] objects;
		protected GameObject entity;
		protected Utils.Position position;
		protected abstract void LoadEntity();

		public Object(Utils.Position position)
		{
			this.position = position;
		}

	}
}