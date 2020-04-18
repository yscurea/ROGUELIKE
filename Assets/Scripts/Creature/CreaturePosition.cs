using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using RogueLikeProject.MyLib;


namespace RogueLikeProject.Creature
{
	public class CreaturePosition : MonoBehaviour
	{
		static CreaturePosition[,] creaturesMap;
		Coordinate coordinate;
		static Dungeon.RoomDirector roomDirector;

		void Start()
		{
			coordinate = roomDirector.GetRandomCoordinate();
			Vector3 targetPosition = new Vector3(
				coordinate.x * Dungeon.DungeonDirector.sqareSize,
				0,
				coordinate.z * Dungeon.DungeonDirector.sqareSize
				);
			GetComponent<CreatureMovement>().SetTargetPosition(targetPosition);
		}

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