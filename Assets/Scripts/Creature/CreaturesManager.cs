using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace RogueLikeProject.Creature
{
	[System.Serializable]
	public class CreaturesObject
	{
		[SerializeField]
		GameObject playerObject;
		List<Creature> creatures = new List<Creature>();

		public void InstantiateCreatures()
		{
			GameObject.Instantiate(playerObject);
		}
	}
}