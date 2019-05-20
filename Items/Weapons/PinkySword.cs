using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.DataStructures;
using TheRedoMod.Projectiles;

namespace TheRedoMod.Items.Weapons
{
    public class PinkySword : ModItem
    {
		public override void SetStaticDefaults()
			{
				DisplayName.SetDefault("Pink Slasher");
			}

        public override void SetDefaults()
        {
			item.maxStack = 1;
			item.autoReuse = true;
			item.useStyle = 1;
			item.useAnimation = 11;
			item.useTime = 11;
			item.width = 24;
			item.height = 22;
			item.knockBack = 2f;
			item.damage = 25;
			item.value = 50000;
			item.rare = 3;
			item.melee = true;
	}}}