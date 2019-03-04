using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheRedoMod.Items.Weapons
{
	public class PhantomBuster : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Phantom Buster");
		}
		public override void SetDefaults()
		{
			item.damage = 120;
			item.width = 40;
			item.height = 40;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 5;
			item.shoot = 10;
			item.rare = 9;
			item.knockBack = 4;
			item.shootSpeed = 650f;
			item.value = Item.sellPrice(0, 4, 0, 0);
			item.ranged = true;
			item.autoReuse = true;
			item.noMelee = true;
			item.useAmmo = AmmoID.Bullet;
			item.UseSound = SoundID.Item11;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.VortexBeater);
			recipe.AddIngredient(ItemID.SniperRifle);
			recipe.AddIngredient(ItemID.LunarBar, 25);
			recipe.AddIngredient(ItemID.Ectoplasm, 25);
			recipe.AddIngredient(3456, 10);
			recipe.AddTile(412);
			recipe.SetResult(this);
			recipe.AddRecipe();
	}}}