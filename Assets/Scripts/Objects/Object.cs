﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace RogueLikeProject.Object
{
	enum Layer
	{
		Character,
		Floor,
		Item,
		Trap
	}
	public class Object
	{
		static Object[,,] objects;
		static Object()
		{

		}
	}

	public abstract class Object2 : Object
	{

	}
}