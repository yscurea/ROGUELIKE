using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RogueLikeProject.Creature
{
	public class CreatureDirector : MonoBehaviour
	{
		[SerializeField] CreaturesObject creatureObject;

		void Start()
		{
			creatureObject.InstantiateCreatures();
		}
	}
}