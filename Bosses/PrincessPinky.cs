using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheRedoMod.Bosses

{
	public class PrincessPinky : ModNPC {

	public override void SetDefaults()
	{
		npc.lifeMax = 5000;
		npc.damage = 70;
		npc.defense = 40;
		npc.width = 61;
		npc.aiStyle = 1;
		npc.height = 58;
		npc.knockBackResist = 0;
		npc.boss = true;
		npc.lavaImmune = true;
		npc.HitSound = SoundID.NPCHit1;
		npc.DeathSound = SoundID.NPCDeath1;
		animationType = NPCID.KingSlime;
		music = MusicID.Boss1;
		Main.npcFrameCount[npc.type] = 6;
}

	public override void NPCLoot()
	{
	Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.PinkGel, 30);
	Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.PinkGel, 1 + Main.rand.Next(8));
	Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.SilverCoin, 28 + Main.rand.Next(6));
}}}