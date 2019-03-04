using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheRedoMod.Items
{
	public class PinkDiamond : ModItem
	{
		public override void SetStaticDefaults() {
		DisplayName.SetDefault("Pink Diamond");
		Tooltip.SetDefault("I would hold on to this if I were you.");
		}
			public override void SetDefaults() {
			item.width = 12;
			item.height = 12;
			item.maxStack = 1;
			item.expert = true;
		}
	}
}