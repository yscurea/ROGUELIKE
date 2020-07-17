using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace RogueLikeProject.Character
{
	[System.Serializable]
	public class CharactersObject : MonoBehaviour
	{
		// resourceから読み込み
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
		public void LoadEnemy()
		{
			characters = Resources.LoadAll<GameObject>("Prefabs/Characters/Enemys");
		}
		public void InstantiateCharacters()
		{
			Instantiate(player);
		}
		//comment
	}
}