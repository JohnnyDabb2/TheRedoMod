using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace TheRedoMod.Items.Placeables
	{
		public class PrincessPinkyTrophy : ModItem
			{
				public override void SetDefaults() {
					item.width = 12;
					item.height = 12;
					item.maxStack = 99;
					item.useAnimation = 15;
					item.useTime = 10;
					item.rare = 1;
					item.useStyle = 1;
					item.consumable = true;
					item.useTurn = true;
					item.autoReuse = true;
					item.createTile = mod.TileType("PrincessPinkyTrophyTile");
			}}}