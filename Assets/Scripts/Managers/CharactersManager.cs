using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RogueLike.Managers
{
	public class CharactersManager
	{
		Stage.StageTerrainProvider stageTerrainProvider;


		public CharactersManager(Stage.StageTerrainProvider stageTerrainProvider)
		{
			this.stageTerrainProvider = stageTerrainProvider;
		}

		public void InitializeCharacters(int floorNum)
		{
			UnityEngine.Debug.Log("charactersManager init");
		}

		public void UpdateCharacters()
		{

		}
	}

}