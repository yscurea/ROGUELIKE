using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using RogueLike.Map;

namespace RogueLike.Manager
{
	public class DungeonManager : MonoBehaviour
	{
		ICanGenerateMap mapManager;

		MapGameObjects mapGameObjects;

		void Start()
		{

			this.mapGameObjects = new MapGameObjects();
			this.mapManager = new MapGeneratorMock();
			this.mapManager.GenerateMap(this.mapGameObjects, new MapSize() { x = 10, z = 10, y = 1 });
		}
	}
}