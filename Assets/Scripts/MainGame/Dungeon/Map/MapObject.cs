﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RogueLikeProject.Dungeon.Map
{
	public class MapObject : Object
	{
		override protected void LoadEntity()
		{
			entity = Resources.Load<GameObject>("hogehoge");
		}

	}

}