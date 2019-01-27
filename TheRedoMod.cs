using Terraria.ModLoader;
using Terraria.ID;
using Terraria;

namespace TheRedoMod
{
	public class TheRedoMod : Mod
	{
	
	public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.Cloud, 30);
			recipe.AddIngredient(ItemID.PiggyBank);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(3213);
			recipe.AddRecipe();
}}}