using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.DataStructures;
using TheRedoMod.Projectiles;

namespace TheRedoMod.Items
{
    public class TerrarianSharkGun : ModItem
    {
		public override void SetStaticDefaults() {
			Tooltip.SetDefault("80% chance to not consume ammo");
		}

        public override void SetDefaults()
        {
			item.maxStack = 1;
			item.damage = 200;
			item.knockBack = 4;
			item.useStyle = 5;
			item.width = 24;
			item.height = 24;
			item.useAnimation = 5;
			item.useTime = 5;
			item.UseSound = SoundID.Item40;
			
			item.shootSpeed = 15f;
            item.rare = 11;
			item.shoot = 10;
			item.shootSpeed = 20f;
			item.useAmmo = AmmoID.Bullet;
			item.crit += 38;
			item.value = Item.sellPrice(gold: 25);
			item.noMelee = true;
			item.ranged = true;
			item.autoReuse = true;
		}

	public override void AddRecipes()
		{	
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Terrarian);
			recipe.AddIngredient(ItemID.SDMG);
			recipe.AddIngredient(ItemID.Megashark);
			recipe.AddIngredient(ItemID.FragmentVortex, 10);
			recipe.AddTile(412);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
			public override bool ConsumeAmmo(Player player)
			{
				return Main.rand.NextFloat() >= .80f;
	}}}