using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.DataStructures;
using TheRedoMod;

	namespace TheRedoMod
		{
			public class RedoPlayer : ModPlayer
		{
			public float DefensiveDamage;
			public override void ResetEffects()
				{
					DefensiveDamage = 1f;
			}}}