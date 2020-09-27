using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RogueLike.Utils
{
	public class Room
	{
		int id;
		Rect rect;

		public Coordinate GetRandomCoordinate()
		{
			return rect.GetRandomCoordinate();
		}
		public Coordinate GetRandomGroundCoordinate()
		{
			return rect.GetRandomCoordinate();
		}
	}
}