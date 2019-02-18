using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace TheRedoMod.Tiles
{
	public class InvisiblePlatform : ModTile
	{
		public override void SetDefaults() {
			Main.tileLighted[Type] = true;
			Main.tileFrameImportant[Type] = true;
			Main.tileSolidTop[Type] = true;
			Main.tileSolid[Type] = true;
			Main.tileNoAttach[Type] = true;
			Main.tileLavaDeath[Type] = true;
			TileID.Sets.Platforms[Type] = true;
			TileObjectData.newTile.CoordinateHeights = new[] { 16 };
			TileObjectData.newTile.CoordinateWidth = 16;
			TileObjectData.newTile.CoordinatePadding = 2;
			TileObjectData.newTile.StyleHorizontal = true;
			TileObjectData.newTile.StyleMultiplier = 27;
			TileObjectData.newTile.StyleWrapLimit = 27;
			TileObjectData.newTile.UsesCustomCanPlace = false;
			TileObjectData.newTile.LavaDeath = true;
			TileObjectData.addTile(Type);
			dustType = mod.DustType("Sparkle");
			drop = mod.ItemType("InvisiblePlatform");
			disableSmartCursor = true;
			adjTiles = new int[] { TileID.Platforms };
		}

		public override void PostSetDefaults() {
			Main.tileNoSunLight[Type] = false;
		}

		public override void NumDust(int i, int j, bool fail, ref int num) {
			num = fail ? 1 : 3;
		}
	}
}