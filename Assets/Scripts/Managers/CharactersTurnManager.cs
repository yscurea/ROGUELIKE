using System.Collections.Generic;
using UnityEngine;

namespace RogueLike.Managers
{
	public class CharactersTurnManager
	{
		Characters.Player.PlayerCore playerCore;
		Characters.Enemy.EnemyList enemies;
		List<Characters.CharacterCore> moveCharacters = new List<Characters.CharacterCore>();

		public void UpdateCharactersTurn()
		{
			Debug.Log("update characters turn");

			Characters.ActionState playerState = playerCore.StartBehave();

			// player none input
			if (playerState == Characters.ActionState.Idle)
			{
				return;
			}

			// player move
			if (playerState == Characters.ActionState.StartMove)
			{
				// enemies decides action
				// cache startMove characters
				moveCharacters.Add(playerCore);
				
			}

			if (playerState == Characters.ActionState.StartAction)
			{

			}
		}
	}
}