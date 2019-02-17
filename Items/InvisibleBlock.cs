using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace TheRedoMod.Items
{
	public class InvisibleBlock : ModItem {


		public override void SetStaticDefaults() {
			Tooltip.SetDefault("mess around with your friends!");
		}


		public override void SetDefaults() {
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("InvisibleBlock");
		}

		public override void AddRecipes()
        {	
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DirtBlock, 5);
			recipe.AddTile(412);
			recipe.SetResult(this);
			recipe.AddRecipe();
}}}