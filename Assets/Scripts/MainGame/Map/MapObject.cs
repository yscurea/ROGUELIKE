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

	}

}