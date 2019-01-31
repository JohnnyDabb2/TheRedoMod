using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheRedoMod.Bosses

{
	public class PrincessPinky : ModNPC
	
{	public override void SetDefaults()
	{
		npc.lifeMax = 3000;
		npc.damage = 80;
		npc.aiStyle = 1;
		npc.defense = 20;
		npc.width = 80;
		npc.height = 80;
		npc.boss = true;
		npc.lavaImmune = true;
		npc.HitSound = SoundID.NPCHit1;
		npc.DeathSound = SoundID.NPCDeath1;
		music = MusicID.Boss1;
		npc.lavaImmune = true;
		npc.noGravity = false;
}

	public override void NPCLoot()
	{
	Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("PinkyPieYoyo"));
	Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.PinkGel, 30);
	Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.PinkGel, 1 + Main.rand.Next(8));
	Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.SilverCoin, 30);
	}}}