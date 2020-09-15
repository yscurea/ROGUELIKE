using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RogueLike.Map
{
	public class MapGeneratorMock : ICanGenerateMap
	{
		MapGameObjects mapGameObjects;
		GameObject wall;

		public bool GenerateMap(MapGameObjects mapGameObjects, MapSize mapSize)
		{
			wall = GameObject.CreatePrimitive(PrimitiveType.Cube);
			for (int i = 0; i < mapSize.z; i++)
			{
				for (int j = 0; j < mapSize.x; j++)
				{
					if (i == 0 || i == mapSize.z - 1 || j == 0 || j == mapSize.x - 1)
						GameObject.Instantiate(wall, new Vector3(x: (float)j, y: 0, z: (float)i), Quaternion.identity);
				}
			}
			return true;
		}
	}
}