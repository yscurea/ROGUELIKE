using RogueLikeProject.Dungeon;
using RogueLikeProject.MyLib;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RogueLikeProject.Character
{
	public class CharactersDirector : MonoBehaviour
	{
		CharactersObject charactersObject;
		DungeonDirector dungeonDirector;
		void Start()
		{
			charactersObject = GetComponent<CharactersObject>();
			Character.InitCharacters(dungeonDirector.dungeonZ, dungeonDirector.dungeonX);
			CharacterPosition.InitCharactersPosition(dungeonDirector.dungeonZ, dungeonDirector.dungeonX);
			GameObject tmp = this.transform.root.gameObject;
			dungeonDirector = this.transform.root.gameObject.transform.Find("DungeonDirector").gameObject.GetComponent<DungeonDirector>();
			//charactersObject.InstantiateCharacters();
		}
		void GenerateCharacter(GameObject character)
		{
			Coordinate crd = dungeonDirector.GetRandomCoordinate();
			var tmp = Instantiate(character, new Vector3(crd.x, 0, crd.z), Quaternion.identity);
			tmp.transform.parent = this.gameObject.transform;
		}
	}
}