using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace RogueLikeProject.Map
{
	public class MapManager
	{
		RoomDirector roomDirector;
		MapObjectManager mapObjectManager;

		public void Init()
		{

		}
		public void GenerateMap(Object[,,] objects)
		{
			MapGenerator mapGenerator = new MapGenerator();
			mapGenerator.GenerateMap(roomDirector.rooms);
		}
		public void Update()
		{

		}
	}
}
