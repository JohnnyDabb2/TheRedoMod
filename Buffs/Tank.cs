using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.DataStructures;

namespace TheRedoMod.Buffs
{
	public class Tank : ModBuff
	{
		public override void SetDefaults() {
			DisplayName.SetDefault("Tank");
			Description.SetDefault("You have 50% increased damage");
			Main.buffNoSave[Type] = false;
		}

		public override void Update(Player player, ref int buffIndex)
			{
				player.magicDamage *= 1.5f;
				player.minionDamage *= 1.5f;
				player.meleeDamage *= 1.5f;
				player.rangedDamage *= 1.5f;
		}}}