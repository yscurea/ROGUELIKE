using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace RogueLikeProject.Creature
{
	public class CreatureManager : MonoBehaviour
	{
		Creature player;

		List<Creature> creatures = new List<Creature>();

		void Start()
		{
			//generate player, generate enemy

		}

		void Update()
		{
			//player -> enemy -> ally -> player
			if (player.Act())
			{

			}
		}
	}
}