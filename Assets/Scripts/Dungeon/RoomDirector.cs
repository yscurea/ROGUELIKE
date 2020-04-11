using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RogueLikeProject.Dungeon
{
	using MyLib;
	public class RoomDirector
	{
		Dictionary<int, Room> rooms;

		public void InitRomms(Dictionary<int, Room> rooms)
		{
			this.rooms = rooms;
		}

		public Coordinate GetRandomCoordinate()
		{
			Room room = rooms[UnityEngine.Random.Range(0, rooms.Count)];

			int xMin = room.rect.start.x;
			int xMax = room.rect.end.x;

			int zMin = room.rect.start.z;
			int zMax = room.rect.end.z;

			Coordinate coordinate;

			coordinate.x = UnityEngine.Random.Range(xMin, xMax);
			coordinate.z = UnityEngine.Random.Range(zMin, zMax);

			return coordinate;
		}




	}
}