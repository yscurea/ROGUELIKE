using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace RogueLikeProject.Map
{
	public class MapManager
	{
		public Object[,,] map { get; }
		public RoomDirector roomDirector { get; }
		MapObjectManager mapObjectManager;

		public void Init()
		{
		}

		public void Update()
		{
			mapObjectManager.Update();
		}

		public void GenerateMap(GameObject parent)
		{
			MapGenerator mapGenerator = new MapGenerator();
			TerrainType[,] tmpMapInfo = mapGenerator.GenerateMap(roomDirector.rooms);
			mapObjectManager.Init();
			mapObjectManager.Instantiate(map, parent, tmpMapInfo);
		}

	}
}
