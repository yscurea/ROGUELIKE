using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace RogueLikeProject.Creature
{
	using MyLib;
	public class CreaturePosition : MonoBehaviour
	{
		private static CreaturePosition[,] creaturesMap;

		private Coordinate coordinate;

		public static void InitCreaturesPosition(int z, int x)
		{
			creaturesMap = new CreaturePosition[z, x];
		}


		public void SwapPosition(Coordinate targetPosition)
		{

		}


	}
}