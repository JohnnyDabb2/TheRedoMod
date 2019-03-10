using System;
using Terraria.ID;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace TheRedoMod.Tiles
{
	public class InvisibleBlockTile : ModTile
	{
		public override void SetDefaults() {
			Main.tileSolid[Type] = true;
			Main.tileMergeDirt[Type] = true;
			Main.tileBlockLight[Type] = true;
			Main.tileLighted[Type] = true;
			drop = mod.ItemType("InvisibleBlock");
	}}}