using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RogueLike.Map
{
	public class MapGameObjects
	{
		GameObject[,,] gameObjects;


		public bool Add(GameObject gameObject, Position position)
		{
			if (gameObjects[position.coordinate.z, position.coordinate.x, (int)position.mapLayer] is null)
			{
				gameObjects[position.coordinate.z, position.coordinate.x, (int)position.mapLayer] = gameObject;
				return true;
			}
			return false;
		}

		public bool Remove(Position position)
		{
			if (gameObjects[position.coordinate.z, position.coordinate.x, (int)position.mapLayer] is null)
			{
				return false;
			}
			gameObjects[position.coordinate.z, position.coordinate.x, (int)position.mapLayer] = null;
			return true;
		}
	}

}