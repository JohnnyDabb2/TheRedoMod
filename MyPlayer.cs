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
            items.RemoveAt(2);
            items.RemoveAt(1);
            items.RemoveAt(0);
			
            Item item = new Item();
            item.SetDefaults(mod.ItemType("GoodieBag"));
            item.stack = 1;
            items.Add(item);
}}}