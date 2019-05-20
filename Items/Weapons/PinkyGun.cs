using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.DataStructures;
using TheRedoMod.Projectiles;

namespace TheRedoMod.Items.Weapons
{
    public class PinkyGun : ModItem
    {
		public override void SetStaticDefaults()
			{
				DisplayName.SetDefault("PIN-K");
			}

        public override void SetDefaults()
        {
			item.maxStack = 1;
			item.autoReuse = true;
			item.useStyle = 5;
			item.useAnimation = 11;
			item.useTime = 11;
			item.width = 17;
			item.height = 22;
			item.shoot = 14;
			item.knockBack = 2f;
			item.useAmmo = AmmoID.Bullet;
			item.UseSound = SoundID.Item41;
			item.damage = 11;
			item.shootSpeed = 19f;
			item.noMelee = true;
			item.rare = 3;
			item.ranged = true;
	}}}