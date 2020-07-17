using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace RogueLikeProject.Character
{
	[System.Serializable]
	public class CharactersObject : MonoBehaviour
	{
		// resourceから読み込み
		GameObject playerObject;
		GameObject[] characters;

		public void Init()
		{
			playerObject = Resources.Load("Prefabs/Characters/Player.prefab") as GameObject;
		}
		public void InitEnemy()
		{
			characters = Resources.LoadAll<GameObject>("Prefabs/Characters/Enemys");
		}
		public void InstantiateCharacters()
		{
			Instantiate(playerObject);
		}
	}
}