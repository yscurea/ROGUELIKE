using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace RogueLikeProject.item
{
	public abstract class Item : RogueLikeProject.Object
	{
		protected abstract void Affect();

		public Item(Utils.Position position) : base(position)
		{

		}
	}

}