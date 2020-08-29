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


	// position on dungeon map
	public struct Position
	{
		Utils.Coordinate coordinate;
		Layer layer;
	}

	public abstract class Object
	{
		// define here for  common functions.
		protected static Object[,,] objects;
		protected GameObject entity;
		protected Position position;
		protected abstract void LoadEntity();

	}
}