using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheRedoMod.Items
{
    public class EndgameToken : ModItem
    {
        public override void SetStaticDefaults()
        {
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
		recipe.SetResult(ItemID.Meowmere);
		recipe.AddRecipe();
		
		ModRecipe recipe1 = new ModRecipe(mod);
        recipe1.AddIngredient(this);
		recipe1.SetResult(ItemID.LastPrism);
		recipe1.AddRecipe();
		
		ModRecipe recipe2 = new ModRecipe(mod);
        recipe2.AddIngredient(this);
		recipe2.SetResult(3570);
		recipe2.AddRecipe();
        
		ModRecipe recipe3 = new ModRecipe(mod);
        recipe3.AddIngredient(this);
		recipe3.SetResult(ItemID.Terrarian);
		recipe3.AddRecipe();
		
		ModRecipe recipe4 = new ModRecipe(mod);
        recipe4.AddIngredient(this);
		recipe4.SetResult(1553);
		recipe4.AddRecipe();
		
		ModRecipe recipe5 = new ModRecipe(mod);
        recipe5.AddIngredient(this);
		recipe5.SetResult(3065);
		recipe5.AddRecipe();
		
		ModRecipe recipe6 = new ModRecipe(mod);
        recipe6.AddIngredient(this);
		recipe6.SetResult(3546);
		recipe6.AddRecipe();
		
		ModRecipe recipe7 = new ModRecipe(mod);
        recipe7.AddIngredient(this);
		recipe7.SetResult(3569);
		recipe7.AddRecipe();
		
		ModRecipe recipe8 = new ModRecipe(mod);
        recipe8.AddIngredient(this);
		recipe8.SetResult(3571);
		recipe8.AddRecipe();
		
		ModRecipe recipe9 = new ModRecipe(mod);
        recipe9.AddIngredient(this);
		recipe9.AddTile(412);
		recipe9.needWater = true;
		recipe9.SetResult(mod.ItemType("EpicToken"));
		recipe9.AddRecipe();
}}}