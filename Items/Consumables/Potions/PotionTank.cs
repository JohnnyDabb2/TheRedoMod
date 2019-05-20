using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.DataStructures;
using TheRedoMod.Buffs;

namespace TheRedoMod.Items.Consumables.Potions
{
    public class PotionTank : ModItem
    {
		public override void SetStaticDefaults()
			{
				DisplayName.SetDefault("Tank Potion");
			}

        public override void SetDefaults()
        {
			item.maxStack = 1;
			item.width = 20;
			item.height = 26;
			item.useStyle = ItemUseStyleID.EatingUsing;
			item.useAnimation = 17;
			item.useTime = 17;
			item.useTurn = true;
			item.UseSound = SoundID.Item3;
			item.maxStack = 30;
			item.consumable = true;
			item.rare = 3;
		}

		public override bool UseItem(Player player)
			{
				player.AddBuff(mod.BuffType<Tank>(), 14000);
				return true;
		}}}