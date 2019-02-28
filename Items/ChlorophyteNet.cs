using System;
using Microsoft.Xna.Framework;
using Terraria.DataStructures;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheRedoMod.Items
{
	public class ChlorophyteNet : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Chlorophyte Bug Net");
		}

		public override void SetDefaults() {
			item.width = 20;
			item.height = 20;
			item.rare = 7;
			item.useStyle = 1;
			item.useAnimation = 25;
			item.width = 24;
			item.height = 28;
			item.damage = 0;
			item.UseSound = SoundID.Item1;
			item.value = Item.sellPrice(0, 20, 0, 0);
			item.autoReuse = true;
			item.useTurn = true;
			item.melee = true;
		}

public override bool UseItem(Player player)
{
	if (Main.myPlayer == player.whoAmI)
		{
			for (int num312 = 0; num312 < 200; num312++)
		{
			if (Main.npc[num312].active && Main.npc[num312].catchItem > 0)
			{
				Rectangle r2 = new Rectangle((int)player.itemLocation.X, (int)player.itemLocation.Y, 40000003, 40000003);
				Rectangle value18 = new Rectangle((int)Main.npc[num312].position.X, (int)Main.npc[num312].position.Y, Main.npc[num312].width, Main.npc[num312].height);
				if (r2.Intersects(value18) && (item.type == 3183 || Main.npc[num312].noTileCollide || player.CanHit(Main.npc[num312])))
			{
		NPC.CatchNPC(num312, player.whoAmI);
	}}}}
    return true;
}}}