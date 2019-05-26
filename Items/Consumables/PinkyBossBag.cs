using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using TheRedoMod;
using TheRedoMod.Items;

namespace TheRedoMod.Items.Consumables
{
	public class PinkyBossBag : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Treasure Bag");
			Tooltip.SetDefault("{$CommonItemTooltip.RightClickToOpen}");
		}

		public override void SetDefaults() {
			item.width = 20;
			item.height = 20;
			item.maxStack = 999;
			item.consumable = true;
			item.expert = true;
			bossBagNPC = mod.NPCType("PrincessPinky");
		}

		public override bool CanRightClick() {
			return true;
		}

	public override void OpenBossBag(Player player) {
        {
			player.QuickSpawnItem(ItemID.PinkGel, 21 + Main.rand.Next(8));
			player.QuickSpawnItem(ItemID.GoldCoin, 1 + Main.rand.Next(2));
			player.QuickSpawnItem(ItemID.SilverCoin, 10 + Main.rand.Next(20));
		}

		switch (Main.rand.Next(4))
				{
					case 0:
						player.QuickSpawnItem(mod.ItemType("PinkaPinka"));
					break;

					case 1:
						player.QuickSpawnItem(mod.ItemType("PinkySword"));
					break;

					case 2:
						player.QuickSpawnItem(mod.ItemType("PinkyGun"));
					break;

					case 3:
						player.QuickSpawnItem(mod.ItemType("PinkiePie"));
					break;
		}}}}