using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.DataStructures;
using TheRedoMod.Projectiles;

namespace TheRedoMod.Items
{
    public class PinkyPie : ModItem
    {
        public override void SetDefaults()
        {
			item.maxStack = 1;
			item.damage = 26;
			item.knockBack = 6;
			item.useStyle = 5;
			item.width = 24;
			item.height = 24;
			item.useAnimation = 25;
			item.useTime = 25;
			item.shootSpeed = 15f;
            item.rare = 3;
			item.crit += 7;
			item.UseSound = SoundID.Item1;
			item.shoot = mod.ProjectileType<PinkyPieProjectile>();
			item.channel = true;
			item.noMelee = true;
			item.noUseGraphic = true;
			item.melee = true;
			item.value = Item.sellPrice(silver: 75);
	}}}