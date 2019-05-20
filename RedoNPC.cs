using System;
using System.IO;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

	namespace TheRedoMod
		{
			public class RedoNPC : GlobalNPC
				{
				public override void NPCLoot(NPC npc)
		{
			if (npc.type == 109)
				Item.NewItem((int) npc.position.X, (int) npc.position.Y, npc.width, npc.height, mod.ItemType("BananaSplitter"));
		}}}