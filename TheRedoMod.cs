using Terraria.ModLoader;
using Terraria.ID;
using Terraria;
using TheRedoMod.Bosses;

namespace TheRedoMod
{
	public class TheRedoMod : Mod
	{
	
	public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.Cloud, 70);
			recipe.AddIngredient(ItemID.PiggyBank);
			recipe.AddTile(412);
			recipe.SetResult(3213);
			recipe.AddRecipe();
}}}