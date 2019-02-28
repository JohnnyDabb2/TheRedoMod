using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheRedoMod.Items
{
	public class GoodieBag : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Goodie Bag");
			Tooltip.SetDefault("Open for some cool stuff!");
		}

		public override void SetDefaults() {
			item.width = 20;
			item.height = 20;
			item.rare = 2;
			item.consumable = true;
		}

		public override bool CanRightClick() {
			return true;
		}

		public override void RightClick(Player player) {
			player.QuickSpawnItem(ItemID.CopperPickaxe);
			player.QuickSpawnItem(ItemID.CopperHammer);
			player.QuickSpawnItem(ItemID.CopperAxe);
			player.QuickSpawnItem(mod.ItemType("PinkyCrown"));
			player.QuickSpawnItem(mod.ItemType("StarterToken"));
			player.QuickSpawnItem(72, 10);
			player.QuickSpawnItem(9, 30);
		}}}