using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

	namespace TheRedoMod
		{
			public class MyPlayer : ModPlayer	
		{
			public override void SetupStartInventory(IList<Item> items)
				{
					Item item = new Item();
					item.SetDefaults(mod.ItemType("StarterToken"));
					item.stack = 1;
					items.Add(item);
				}}}