using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RogueLikeProject.Dungeon
{
	using RogueLikeProject.Map;
	using Character;
	public class DungeonDirector : MonoBehaviour
	{
		// Is dungeon size variabillity?
		public int dungeonZ { get; } = 30;
		public int dungeonX { get; } = 54;

		int floorNumber = 1;
		public static float sqareSize = 1.0f;

		MapManager mapManager;
		CharactersManager charactersManager;

		void Start()
		{
			/*
			first, generate dungeon_map;
				GenerateMap;
				Instantiate map_objects;
			second, generate character based on dungeon_map;
				Instantiate player;
				Instantiate others characters;
			*/
			mapManager.Init();
			mapManager.GenerateMap(this.gameObject);
			charactersManager.Init(mapManager.map, mapManager.roomDirector);
		}

		void Update()
		{
			/*
			check gameover;
			wait for player's input;
			if there were players input, players act and characters act after that;
			*/
			mapManager.Update();
			charactersManager.Update();
		}

	}
}