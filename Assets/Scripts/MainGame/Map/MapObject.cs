using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RogueLikeProject.Map
{
	public abstract class MapObject : Object
	{
		protected MapObject(Utils.Position position) : base(position)
		{

		}

		// if MapObject can do something, use this function with override.
		// this function is called per frame.
		public virtual void Update()
		{

		}

	}

}