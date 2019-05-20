using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.DataStructures;

namespace TheRedoMod.Items.Other
{
    public class StarterToken : ModItem
    {
		public override void SetStaticDefaults()
			{
				Tooltip.SetDefault("Choose your own adventure!");
				Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(5, 2));
			}

		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 1;
			item.value = 400;
			item.rare = 2;
		}
			public override void AddRecipes()
		{
			ModRecipe recipe1 = new ModRecipe(mod);
			recipe1.AddIngredient(this);
			recipe1.SetResult(224);
			recipe1.AddRecipe();

			ModRecipe recipe2 = new ModRecipe(mod);
			recipe2.AddIngredient(this);
			recipe2.SetResult(ItemID.Furnace);
			recipe2.AddRecipe();

			ModRecipe recipe3 = new ModRecipe(mod);
			recipe3.AddIngredient(this);
			recipe3.SetResult(43);
			recipe3.AddRecipe();

			ModRecipe recipe4 = new ModRecipe(mod);
			recipe4.AddIngredient(this);
			recipe4.SetResult(3278);
			recipe4.AddRecipe();
	}}}