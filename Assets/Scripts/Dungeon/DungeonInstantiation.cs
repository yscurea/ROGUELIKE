using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace RogueLikeProject.Dungeon
{
	[System.Serializable]
	public class DungeonInstantiation
	{
		[SerializeField]
		private GameObject wall;

		[SerializeField]
		private GameObject floor;


		public void DungeonInstantiate(TerrainType[,] dungeonInfo)
		{

			for (int zi = 0; zi < dungeonInfo.GetLength(0); zi++)
			{
				for (int xi = 0; xi < dungeonInfo.GetLength(1); xi++)
				{
					switch (dungeonInfo[zi, xi])
					{
						case TerrainType.Room:
							break;
						case TerrainType.Way:
							break;
						case TerrainType.InsideWall:
						case TerrainType.Wall:
							GameObject.Instantiate(wall, new Vector3(xi, 0, zi), Quaternion.identity);
							break;
						default:
							break;
					}
				}
			}
		}
	}
}