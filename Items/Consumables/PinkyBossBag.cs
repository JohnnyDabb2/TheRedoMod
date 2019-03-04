using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using TheRedoMod;

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

	public override void OpenBossBag(Player player)
        {
			player.QuickSpawnItem(mod.ItemType("PinkDiamond"));
			player.QuickSpawnItem(ItemID.PinkGel, 30);
			player.QuickSpawnItem(ItemID.PinkGel, 1 + Main.rand.Next(8));
			player.QuickSpawnItem(mod.ItemType<Items.Weapons.PinkyPie>());
			player.QuickSpawnItem(ItemID.GoldCoin, 1 + Main.rand.Next(2));
			player.QuickSpawnItem(ItemID.SilverCoin, 10 + Main.rand.Next(20));
	}}}