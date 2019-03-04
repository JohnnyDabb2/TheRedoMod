using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheRedoMod.Items.Platforms
{
	public class InvisiblePlatform : ModItem
	{
		public override void SetStaticDefaults() {
			Tooltip.SetDefault("Mess around with your friends!");
		}

		public override void SetDefaults() {
			item.width = 8;
			item.height = 10;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("InvisiblePlatform");
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("InvisibleBlock"));
			recipe.SetResult(this, 2);
			recipe.AddRecipe();
		}
	}
}