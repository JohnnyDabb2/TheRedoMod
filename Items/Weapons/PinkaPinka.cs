using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.DataStructures;
using TheRedoMod.Projectiles;

namespace TheRedoMod.Items.Weapons
{
    public class PinkaPinka : ModItem
    {
        public override void SetDefaults()
        {
			item.maxStack = 1;
			item.mana = 8;
			item.damage = 23;
			item.useStyle = 5;
			item.shootSpeed = 2f;
			item.shoot = 121;
			item.width = 26;
			item.height = 28;
			item.UseSound = SoundID.Item43;
			item.useAnimation = 20;
			item.useTime = 20;
			item.rare = 3;
			item.noMelee = true;
			item.knockBack = 4f;
			item.autoReuse = true;
			item.magic = true;
	}}}