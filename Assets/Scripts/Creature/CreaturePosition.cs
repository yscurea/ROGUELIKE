using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using RogueLikeProject.MyLib;


namespace RogueLikeProject.Creature
{
	public class CreaturePosition : MonoBehaviour
	{
		private static CreaturePosition[,] creaturesMap;
		private Coordinate coordinate;
		static Dungeon.RoomDirector roomDirector;

		public static void InitCreaturesPosition(int z, int x)
		{
			creaturesMap = new CreaturePosition[z, x];
		}
		public void SwapPosition(Coordinate targetPosition)
		{
			void swap<T>(ref T lhs, ref T rhs)
			{
				T tmp;
				tmp = lhs;
				lhs = rhs;
				rhs = tmp;
			}
			swap(ref creaturesMap[targetPosition.z, targetPosition.x], ref creaturesMap[coordinate.z, coordinate.x]);
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