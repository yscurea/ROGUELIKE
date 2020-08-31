using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace RogueLikeProject.Map
{
	public class MapManager
	{
		Object[,,] map;
		RoomDirector roomDirector;
		MapObjectManager mapObjectManager;

		public void Init()
		{
		}
		public ref Object[,,] GenerateMap(GameObject parent)
		{
			MapGenerator mapGenerator = new MapGenerator();
			TerrainType[,] tmpMapInfo = mapGenerator.GenerateMap(roomDirector.rooms);
			mapObjectManager.Init();
			mapObjectManager.Instantiate(map, parent, tmpMapInfo);
			return ref map;
		}
		public void Update()
		{
			mapObjectManager.Update();
		}
	}
}
