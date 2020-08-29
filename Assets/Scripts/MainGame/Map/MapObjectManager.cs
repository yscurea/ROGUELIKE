using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace RogueLikeProject.Map
{
	public class MapObjectManager
	{

		// Object loaded ares random?
		GameObject wall, floor;

		public void Init()
		{
			// this is unuseless now.
		}
		public void MapInstantiate(GameObject parent, TerrainType[,] dungeonInfo)
		{
			wall = (GameObject)Resources.Load("Prefabs/DungeonObjects/Normal/Wall");
			if (wall is null)
				Debug.Log("wall is null");
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
									xi * Dungeon.DungeonDirector.sqareSize,
									0,
									zi * Dungeon.DungeonDirector.sqareSize
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