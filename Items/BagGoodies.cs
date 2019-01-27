using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheRedoMod.Items
{
	public class BagGoodies : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Goodie Bag");
			Tooltip.SetDefault("Open for some cool stuff!");
		}

		public override void SetDefaults() {
			item.width = 20;
			item.height = 20;
			item.rare = 2;
		}

		public override bool CanRightClick() {
			return true;
		}

		public override void RightClick(Player player) {
			player.QuickSpawnItem(ItemID.LifeCrystal, 1);
			player.QuickSpawnItem(ItemID.ManaCrystal, 1);
			player.QuickSpawnItem(ItemID.IronPickaxe, 1);
			player.QuickSpawnItem(ItemID.IronHammer, 1);
			player.QuickSpawnItem(ItemID.IronAxe, 1);
			player.QuickSpawnItem(mod.ItemType("PinkyCrown"), 1);
			player.QuickSpawnItem(mod.ItemType("StarterToken"), 1);
			player.QuickSpawnItem(72, 10);
			player.QuickSpawnItem(9, 100);
		}}}