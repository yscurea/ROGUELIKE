using RogueLikeProject.Dungeon;
using RogueLikeProject.MyLib;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RogueLikeProject.Character
{
	public class CharactersDirector : MonoBehaviour
	{
		int character_num = 0;
		int max_character_num = 10;
		CharactersObject charactersObject;
		CharacterGenerator characterGenerator;
		DungeonDirector dungeonDirector;

		public void Init()
		{
			charactersObject = GetComponent<CharactersObject>();
			// charactersObject.InstantiateCharacters();
			// Character.InitCharacters(dungeonDirector.dungeonZ, dungeonDirector.dungeonX);
			// CharacterPosition.InitCharactersPosition(dungeonDirector.dungeonZ, dungeonDirector.dungeonX);

			// dungeonDirector = this.transform.root.gameObject.transform.Find("DungeonDirector").gameObject.GetComponent<DungeonDirector>();
		}
		void GenerateCharacter(GameObject character)
		{
			// ランダム座標にcharaを生成
			Coordinate crd = dungeonDirector.GetRandomCoordinate();
			var tmp = Instantiate(character, new Vector3(crd.x, 0, crd.z), Quaternion.identity);
			tmp.transform.parent = this.gameObject.transform;

			character_num++;
		}

		public void Input()
		{

		}
	}
}