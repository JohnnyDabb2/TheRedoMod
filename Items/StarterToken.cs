using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheRedoMod.Items
{
    public class StarterToken : ModItem
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
		recipe.SetResult(ItemID.MagicMirror);
		recipe.AddRecipe();
		
		ModRecipe recipe1 = new ModRecipe(mod);
        recipe1.AddIngredient(this);
		recipe1.SetResult(ItemID.SlimeStaff);
		recipe1.AddRecipe();
		
		ModRecipe recipe2 = new ModRecipe(mod);
        recipe2.AddIngredient(this);
		recipe2.SetResult(ItemID.WaterBolt);
		recipe2.AddRecipe();
        
		ModRecipe recipe3 = new ModRecipe(mod);
        recipe3.AddIngredient(this);
		recipe3.SetResult(ItemID.GoldBroadsword);
		recipe3.AddRecipe();
		
		ModRecipe recipe4 = new ModRecipe(mod);
        recipe4.AddIngredient(this);
		recipe4.SetResult(ItemID.GoldBow);
		recipe4.AddRecipe();
		}
    }
}