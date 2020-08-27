using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using RogueLikeProject.MyLib;

namespace RogueLikeProject.Character
{
	public class CharacterGenerator
	{
		CharactersObject charactersObject;
		CharacterPosition characterPosition;

		public static void Init(int Zsize, int Xsize)
		{
			CharacterPosition.InitCharactersPosition(Zsize, Xsize);
		}
		public bool GenerateCharacter()
		{
			GameObject character = charactersObject.GetRandomObject();
			MyLib.Coordinate crd = characterPosition.GetRandomCoordinate();
			GameObject tmp = GameObject.Instantiate(
				character,
				new Vector3(crd.z * Dungeon.DungeonDirector.sqareSize, 0, crd.x * Dungeon.DungeonDirector.sqareSize),
				Quaternion.identity
			);

			tmp.transform.parent = this.transform;

			// Script上で位置初期化とキャラ生成
			Character ch = tmp.GetComponent<Character>();
			CharacterPosition position = tmp.GetComponent<CharacterPosition>();
			position.InitPosition(crd);
			return true;
		}
	}
}