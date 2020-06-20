using RogueLikeProject.Dungeon;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RogueLikeProject.Character
{
	public class CharactersDirector : MonoBehaviour
	{
		DungeonDirector dungeonDirector;
		CharactersObject charactersObject;
		void Start()
		{
			GameObject tmp = this.transform.root.gameObject;
			dungeonDirector = this.transform.root.gameObject.transform.Find("DungeonDirector").gameObject.GetComponent<DungeonDirector>();
			//charactersObject.InstantiateCharacters();
		}
	}
}