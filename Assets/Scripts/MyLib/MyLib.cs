using System.Collections;
using System.Collections.Generic;
using UnityEngine;


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
	}

	public class Random
	{

	}

}