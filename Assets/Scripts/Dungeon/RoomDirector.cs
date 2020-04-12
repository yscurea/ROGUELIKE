﻿using System.Collections;
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
			return room.RandomCoordinate();
		}
	}
}