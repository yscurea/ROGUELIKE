using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace RogueLikeProject.Utils
{
	public struct Coordinate
	{
		public int x;
		public int z;
		public static Coordinate operator +(Coordinate coordinate, Direction dir)
		{
			switch (dir)
			{
				case Direction.East:
					coordinate.x++;
					break;
				case Direction.North:
					coordinate.z--;
					break;
				case Direction.South:
					coordinate.z++;
					break;
				case Direction.West:
					coordinate.x--;
					break;
				case Direction.NorthEast:
					coordinate.z--;
					coordinate.x++;
					break;
				case Direction.NorthWest:
					coordinate.z--;
					coordinate.x--;
					break;
				case Direction.SouthEast:
					coordinate.z++;
					coordinate.x++;
					break;
				case Direction.SouthWest:
					coordinate.z++;
					coordinate.x--;
					break;
				case Direction.None:
					break;
			}
			return coordinate;
		}
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

			foreach (Direction dir in Enum.GetValues(typeof(Direction)))
			{
				directions.Add(dir);
			}

			return directions[UnityEngine.Random.Range(0, directions.Count)];
		}

	}

}

namespace RogueLikeProject.Map
{
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
		public Utils.Direction direction;
		public Utils.Coordinate coordinate;
	}
	public class Room
	{
		public Utils.Rect rect;
		public List<Utils.Coordinate> entrances;

		public Utils.Coordinate RandomCoordinate()
		{
			int xMin = rect.start.x;
			int xMax = rect.end.x;

			int zMin = rect.start.z;
			int zMax = rect.end.z;

			Utils.Coordinate coordinate;

			coordinate.x = UnityEngine.Random.Range(xMin, xMax);
			coordinate.z = UnityEngine.Random.Range(zMin, zMax);

			return coordinate;
		}
	}
}
