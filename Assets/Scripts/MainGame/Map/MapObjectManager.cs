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
		public void Instantiate(Object[,,] objects, GameObject parent, TerrainType[,] generatedMapInfo)
		{
			for (int zi = 0; zi < generatedMapInfo.GetLength(0); zi++)
			{
				for (int xi = 0; xi < generatedMapInfo.GetLength(1); xi++)
				{
					switch (generatedMapInfo[zi, xi])
					{
						case TerrainType.InsideWall:
						case TerrainType.Wall:
							Utils.Position position = new Utils.Position() { coordinate = new Utils.Coordinate() { x = xi, z = zi }, layer = Utils.Layer.Character };
							objects[xi, zi, (int)Utils.Layer.Character] = new NormalWall(position);
							break;
						case TerrainType.Way:
							break;
						case TerrainType.Room:
							break;
						default:
							break;
					}
				}
			}
		}
	}
}