using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RogueLike.Map
{
	public interface ICanGenerateMap
	{
		bool GenerateMap(MapSize mapSize);
	}

}