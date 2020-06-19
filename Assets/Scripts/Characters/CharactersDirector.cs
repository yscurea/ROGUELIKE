using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RogueLikeProject.Character
{
	public class CharacterDirector : MonoBehaviour
	{
		[SerializeField] GameObject dungeonDirector;
		[SerializeField] CharactersObject charactersObject;
		void Start()
		{
			charactersObject.InstantiateCharacters();
		}
	}
}