using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace RogueLikeProject
{
	enum Layer
	{
		Character,
		Floor,
		Item,
		Trap
	}

	struct Position
	{
		MyLib.Coordinate coordinate;
		Layer layer;
	}

	public abstract class Object
	{
		static Object[,,] objects { get; }

		// define here for  common functions.

		Position position;
	}
}