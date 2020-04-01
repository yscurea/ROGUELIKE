using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace RogueLikeProject.MyLib
{
	public struct Coordinate
	{
		public int x;
		public int z;
	}
	public struct Rect
	{
		public Coordinate start;
		public Coordinate end;
	}


	public enum Direction
	{
		North,
		East,
		South,
		West,
		NorthEast,
		SouthEast,
		SouthWest,
		NorthWest,
		None,
	}

	public class Random
	{
		public static Direction RandomFourDirection()
		{
			List<Direction> directions = new List<Direction>();

			directions.Add(Direction.North);
			directions.Add(Direction.East);
			directions.Add(Direction.South);
			directions.Add(Direction.West);

			return directions[UnityEngine.Random.Range(0, directions.Count)];
		}

		public static Direction RandomDirection()
		{
			List<Direction> directions = new List<Direction>();

			foreach(Direction dir in Enum.GetValues(typeof(Direction)))
			{
				directions.Add(dir);
			}

			return directions[UnityEngine.Random.Range(0, directions.Count)];
		}

	}

}

namespace RogueLikeProject.Dungeon
{
	using MyLib;
	public enum TerrainType
	{
		Wall,
		InsideWall,
		Way,
		Room,
		Entrance,
		Splitter
	}

	public struct Node
	{
		public Direction direction;
		public Coordinate coordinate;
	}
	public class Room
	{
		public Rect rect;
		public List<Coordinate> entrances;
	}
}
