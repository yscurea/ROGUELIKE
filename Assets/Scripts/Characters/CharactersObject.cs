using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace RogueLikeProject.Character
{
	[System.Serializable]
	public class CharactersObject : MonoBehaviour
	{
		// resourceから読み込む
		// player(操作可能キャラ)を複数にするかどうかは要検討
		GameObject player;
		GameObject[] characters;

		public void Init()
		{
			LoadPlayer();
			LoadEnemy();
		}

		public void LoadPlayer()
		{
			player = Resources.Load("Prefabs/Characters/Player") as GameObject;
		}

		// 階層によって読み込むキャラを変更する？
		public void LoadEnemy()
		{
			characters = Resources.LoadAll<GameObject>("Prefabs/Characters/Enemys");
		}
		public void InstantiateCharacters()
		{
			this.LoadPlayer();
			Instantiate(player);
		}
	}
}