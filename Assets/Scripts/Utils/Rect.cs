using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RogueLike.Utils
{
	public class Rect
	{
		public Coordinate start;
		public Coordinate end;

		public Coordinate GetRandomCoordinate()
		{
			Coordinate result;
			result.vertical = (this.start.vertical + this.end.vertical) / 2;
			result.horizontal = (this.start.horizontal + this.end.horizontal) / 2;
			return result;
		}

	}
}