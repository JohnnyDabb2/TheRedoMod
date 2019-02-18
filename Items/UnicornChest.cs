using Terraria.ID;
using Terraria.ModLoader;

namespace TheRedoMod.Items
{
	public class UnicornChest : ModItem
	{
		public override void SetDefaults() {
			item.width = 26;
			item.height = 22;
			item.maxStack = 99;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = 1;
			item.consumable = true;
			item.value = 500;
			item.createTile = mod.TileType("UnicornChest");
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(3181);
			recipe.AddIngredient(526, 5);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}