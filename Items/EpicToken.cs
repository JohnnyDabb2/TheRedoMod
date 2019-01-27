using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheRedoMod.Items
{
    public class EpicToken : ModItem
    {
        public override void SetStaticDefaults()
        {
			DisplayName.SetDefault("Token of Epicness");
            Tooltip.SetDefault("What do you want?");
        }

        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 1;
            item.value = 400;
            item.rare = 1;
        }

        public override void AddRecipes()
        {
		ModRecipe recipe = new ModRecipe(mod);
        recipe.AddIngredient(this);
		recipe.SetResult(mod.ItemType("Enigmata"));
		recipe.AddRecipe();
		
		ModRecipe recipe1 = new ModRecipe(mod);
        recipe1.AddIngredient(this);
		recipe1.SetResult(mod.ItemType("TheProduct"));
		recipe1.AddRecipe();
		
		ModRecipe recipe2 = new ModRecipe(mod);
        recipe2.AddIngredient(this);
		recipe2.SetResult(ItemID.LunarBar, 200);
		recipe2.AddRecipe();
		
		ModRecipe recipe3 = new ModRecipe(mod);
        recipe3.AddIngredient(this);
		recipe3.SetResult(ItemID.PlatinumCoin, 40);
		recipe3.AddRecipe();
}}}