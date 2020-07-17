using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using RogueLikeProject.MyLib;


namespace RogueLikeProject.Character
{
	public class CharacterPosition
	{
		static CharacterPosition[,] charactersMap;
		Coordinate coordinate;

		public static void InitCharactersPosition(int z, int x)
		{
			charactersMap = new CharacterPosition[z, x];
		}
		public bool SwapPosition(Coordinate targetPosition)
		{
			// swap(ref charactersMap[targetPosition.z, targetPosition.x], ref charactersMap[coordinate.z, coordinate.x]);
			return true;
		}
		public Coordinate GetPosition()
		{
			return coordinate;
		}
		public void UpdatePosition(Direction dir)
		{
			coordinate += dir;
		}
	}
}