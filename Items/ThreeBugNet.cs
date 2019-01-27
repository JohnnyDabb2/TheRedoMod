using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheRedoMod.Items
{
	public class ThreeBugNet : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Titanium Catcher");
		}
		public override void SetDefaults()
		{
			item.melee = true;
			item.width = 800;
			item.height = 800;
			item.useTime = 22;
			item.useAnimation = 25;
			item.useTurn = true;
			item.useStyle = 1;
			item.knockBack = 0;
			item.value = 40;
			item.rare = 5;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()
{
		ModRecipe recipe = new ModRecipe(mod);
        recipe.AddIngredient(3183);
		recipe.AddIngredient(1198, 20);
		recipe.AddTile(412);
		recipe.SetResult(this);
		recipe.AddRecipe();
}}}