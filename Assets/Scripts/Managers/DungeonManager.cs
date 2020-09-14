using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using RogueLike.Map;

namespace RogueLike.Manager
{
	public class DungeonManager : MonoBehaviour
	{
		ICanGenerateMap mapManager = new MapGeneratorMock();

		void Start()
		{

		}
	}
}