using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace RogueLikeProject.Dungeon
{
	public class DungeonObject : MonoBehaviour
	{
		GameObject wall, floor;

		public void DungeonInstantiate(TerrainType[,] dungeonInfo)
		{
			wall = (GameObject)Resources.Load("Prefabs/DungeonObjects/Normal/Wall");
			if (wall is null)
			{
				Debug.Log("wall is null");
			}
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
							tmp = Instantiate(
								wall,
								new Vector3(
									xi * DungeonDirector.sqareSize,
									0,
									zi * DungeonDirector.sqareSize
								),
								Quaternion.identity
							);
							tmp.transform.parent = this.transform;
							break;
						default:
							break;
					}
				}
			}
		}
	}
}