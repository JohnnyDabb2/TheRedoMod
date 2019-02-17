using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheRedoMod.Items
{
	public class LavasparkBoots : ModItem
	{
		public override void SetStaticDefaults() {
		DisplayName.SetDefault("Lavaspark Footwear");
		Tooltip.SetDefault("Combines the effects of the Lava Waders and Frostspark Boots.");
		}

			public override void SetDefaults() {
			item.width = 12;
			item.height = 12;
			item.maxStack = 1;
			item.rare = 7;
			item.accessory = true;
			}

		public override void AddRecipes()
        {	
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(908);
			recipe.AddIngredient(1862);
			recipe.AddTile(114);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.findTreasure = true;

        }}}