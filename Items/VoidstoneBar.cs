using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace TheRedoMod.Items
{
	public class VoidstoneBar : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Voidstone Bar");
		}

		public override void SetDefaults() {
			item.width = 12;
			item.height = 12;
			item.maxStack = 99;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = 1;
			item.consumable = true;
			item.useTurn = true;
			item.autoReuse = true;
			item.createTile = mod.TileType("VoidstoneBarTile");
		}}}