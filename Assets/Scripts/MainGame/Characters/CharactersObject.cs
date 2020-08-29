using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using RogueLikeProject.Utils;
namespace RogueLikeProject.Character
{
	[System.Serializable]
	public class CharacterObject
	{
		// resourceから読み込む
		// player(操作可能キャラ)を複数にするかどうかは要検討
		GameObject player;
		GameObject[] characters;

		// GameObject[] Ally?

		public void Init()
		{
			/// 管理するオブジェクトのロード
			LoadPlayer();
			LoadEnemy();
		}

		public void LoadPlayer()
		{
			// parameterの引継ぎをどうするか考える
			player = Resources.Load("Prefabs/Characters/Player") as GameObject;
		}

		// 階層によって読み込むキャラを変更する？
		public void LoadEnemy(/*path?*/)
		{
			characters = Resources.LoadAll<GameObject>("Prefabs/Characters/Enemys");
		}
		public void InstantiateCharacters(Coordinate coordinate, GameObject character)
		{
			GameObject.Instantiate(
				character,
				new Vector3(
					coordinate.x * Dungeon.DungeonDirector.sqareSize,
					0,
					coordinate.z * Dungeon.DungeonDirector.sqareSize),
				Quaternion.identity
			);
		}
	}
}