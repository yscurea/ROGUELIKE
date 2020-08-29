using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace RogueLikeProject.Map
{
	using Utils;
	public abstract class Wall : MapObject
	{
		public Wall(Position position) : base(position)
		{
			// none
		}
	}

	public class NormalWall : Wall
	{
		public NormalWall(Position position) : base(position)
		{
			// none
		}
		override protected void LoadEntity()
		{
			this.entity = (GameObject)Resources.Load("Prefabs/DungeonObjects/Normal/Wall");
		}
	}
}