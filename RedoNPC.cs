using System;
using System.IO;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using TheRedoMod.Items;

	namespace TheRedoMod
		{
			public class RedoNPC : GlobalNPC
				{
					public override void NPCLoot(NPC npc) {
						if (npc.type == 109)
							if (Main.rand.Next(21) == 0) {
								Item.NewItem((int) npc.position.X, (int) npc.position.Y, npc.width, npc.height, mod.ItemType("BananaSplitter"));
									}
						if (npc.type == 113) {
								Item.NewItem((int) npc.position.X, (int) npc.position.Y, npc.width, npc.height, mod.ItemType("DefensiveEmblem"));
				}}}}