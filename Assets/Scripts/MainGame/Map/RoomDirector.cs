using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RogueLikeProject.Map
{
	public class RoomDirector : MonoBehaviour
	{
		// カプセル化を検討
		public Dictionary<int, Room> rooms;


		public RoomDirector()
		{
			rooms = new Dictionary<int, Room>();
		}
		public Utils.Coordinate GetRandomCoordinate()
		{
			Room room = rooms[UnityEngine.Random.Range(0, rooms.Count)];
			return room.RandomCoordinate();
		}
	}
}