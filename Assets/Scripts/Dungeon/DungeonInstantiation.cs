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


		public void DungeonInstantiate(TerrainType[,] dungeonInfo,GameObject parent)
		{

			for (int zi = 0; zi < dungeonInfo.GetLength(0); zi++)
			{
				for (int xi = 0; xi < dungeonInfo.GetLength(1); xi++)
				{
					GameObject tmp;
					switch (dungeonInfo[zi, xi])
					{
						case TerrainType.Room:
							break;
						case TerrainType.Way:
							break;
						case TerrainType.InsideWall:
						case TerrainType.Wall:
							tmp = GameObject.Instantiate(
								wall,
								new Vector3(
									xi * DungeonDirector.sqareSize,
									0,
									zi * DungeonDirector.sqareSize
								),
								Quaternion.identity
							);
							tmp.transform.parent = parent.transform;
							break;
						default:
							break;
					}
				}
			}
		}
	}
}