using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria;
using Terraria.ModLoader;
using TheRedoMod;
using Terraria.DataStructures;

namespace TheRedoMod.Items.Other
{
    public class ExplosiveItem : ModItem
    {
		public static bool explosive = true;

		public override void SetDefaults()
		{
			item.melee = false;
			item.summon = false;
			item.ranged = false;
			item.magic = false;
			item.thrown = false;
		}

	public override void ModifyTooltips(List<TooltipLine> tooltips)
	{
	TooltipLine tt = tooltips.FirstOrDefault(x => x.Name == "Damage" && x.mod == "Terraria");
	int index = tooltips.FindIndex(x => x.Name == "Damage" && x.mod == "Terraria");
	if (tt != null)
		{
			string[] split = tt.text.Split(' ');
			tt.text = split.First() + " explosive " + split.Last();
	}}

		public override void GetWeaponDamage(Player player, ref int damage)
			{
				RedoPlayer modPlayer = player.GetModPlayer<RedoPlayer>(mod);
				int OriginalDamage = damage;
				damage = (int)(damage * modPlayer.ExplosiveDamage);
				float globalDmg = 1f;
				globalDmg = player.meleeDamage - 1;
				if (player.magicDamage - 1 < globalDmg)
					globalDmg = player.magicDamage - 1;
				if (player.thrownDamage - 1 < globalDmg)
					globalDmg = player.thrownDamage - 1;
				if (player.rangedDamage - 1 < globalDmg)
					globalDmg = player.rangedDamage - 1;
				if (player.minionDamage - 1 < globalDmg)
					globalDmg = player.minionDamage - 1;
				if (globalDmg > 1)
					damage = damage + (int)(OriginalDamage * globalDmg);
		}}}