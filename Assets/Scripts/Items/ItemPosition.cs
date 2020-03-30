using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace RogueLikeProject.item
{
	public class ItemPosition : MonoBehaviour
	{
		private static ItemPosition[,] itemsMap;

		public static void InitItemsPosition(int z, int x)
		{
			itemsMap = new ItemPosition[z, x];
		}



	}
}