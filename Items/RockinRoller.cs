using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

	namespace TheRedoMod.Items
	{
		public class RockinRoller : ModItem
			{
			public override void SetStaticDefaults() {
				DisplayName.SetDefault("Rockin' Roller");
			}

			public override void SetDefaults() {
				item.damage = 90;
				item.width = 40;
				item.height = 40;
				item.useTime = 7;
				item.useAnimation = 15;
				item.axe = 40;
				item.hammer = 160;
				item.useStyle = 1;
				item.knockBack = 5;
				item.scale = 1.16f;
				item.tileBoost = 3;
				item.rare = 10;
				item.UseSound = SoundID.Item1;
				item.autoReuse = true;
				item.melee = true;
			}
				public override void AddRecipes() {
				ModRecipe recipe = new ModRecipe(mod);
				recipe.AddIngredient(ItemID.TheAxe);
				recipe.AddIngredient(ItemID.LunarBar, 15);
				recipe.AddTile(412);
				recipe.SetResult(this);
				recipe.AddRecipe();
		}}}