using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RogueLike.Map
{
	public class FloorGenerator : ICanGenerateMap
	{
		public bool GenerateMap(MapGameObjects mapGameObjects, MapSize mapSize)
		{
			for (int i = 0; i < mapSize.z; i++)
			{
				for (int j = 0; j < mapSize.x; i++)
				{

				}
			}
			return true;
		}
	}
}