using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RogueLike.Map
{
	public class MapGeneratorMock : ICanGenerateMap
	{
		MapGameObjects mapGameObjects;
		public bool GenerateMap(MapSize mapSize)
		{
			for (int i = 0; i < mapSize.z; i++)
			{
				for (int j = 0; j < mapSize.x; j++)
				{
				}
			}
			return true;
		}
	}
}