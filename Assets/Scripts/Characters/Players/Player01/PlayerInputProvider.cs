using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RogueLike.Character.Player
{
	public class PlayerInputProvider : IInputProvider
	{
		float horizontal;
		float vertical;

		float threshold = 0.1f;


		// TBC
		public Vector3 InputDirection()
		{
			this.horizontal = Input.GetAxis("Horizontal");
			this.vertical = Input.GetAxis("Vertical");
			if (this.horizontal > threshold) this.horizontal = 1.0f;
			else if (this.horizontal < -threshold) this.horizontal = -1.0f;
			else this.horizontal = 0.0f;
			if (this.vertical > threshold) this.vertical = 1.0f;
			else if (this.vertical < -threshold) this.vertical = -1.0f;
			else this.vertical = 0.0f;
			return new Vector3(x: this.horizontal, y: 0, z: this.vertical);
		}
	}
}