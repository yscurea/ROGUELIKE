using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace RogueLikeProject.Character
{
	[System.Serializable]
	public class CharactersObject : MonoBehaviour
	{
		[SerializeField]
		GameObject playerObject;
		List<Character> characters = new List<Character>();

		public void InstantiateCharacters()
		{
			Instantiate(playerObject);
		}
	}
}