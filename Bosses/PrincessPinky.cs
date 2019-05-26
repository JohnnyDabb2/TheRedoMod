using System;
using Microsoft.Xna.Framework;
using Terraria.Localization;
using Terraria;
using Terraria.ID;
using TheRedoMod.Items;
using Terraria.ModLoader;

namespace TheRedoMod.Bosses
{
	[AutoloadBossHead]
		public class PrincessPinky : ModNPC
{
	public override void SetDefaults() {
		npc.lifeMax = 7000;
		npc.damage = 30;
		npc.defense = 30;
		npc.aiStyle = 1;
		npc.width = 150;
		npc.height = 100;
		npc.knockBackResist = 0;
		npc.boss = true;
		npc.lavaImmune = true;
		npc.HitSound = SoundID.NPCHit1;
		npc.DeathSound = SoundID.NPCDeath1;
		animationType = NPCID.KingSlime;
		music = MusicID.Boss1;
		Main.npcFrameCount[npc.type] = 6;
		bossBag = mod.ItemType("PinkyBossBag");
	}

		public override void ScaleExpertStats(int numPlayers, float bossLifeScale)
		{
			npc.lifeMax = (int)(npc.lifeMax * 0.5f * bossLifeScale);
			npc.damage = (int)(npc.damage * 0.5f);
		}

	public override void NPCLoot()
	{
					if (!RedoWorld.downedPrincessPinky) {
				RedoWorld.downedPrincessPinky = true;
				if (Main.netMode == NetmodeID.Server) {
					NetMessage.SendData(MessageID.WorldData);
				}}

		if (Main.expertMode)
				{
				npc.DropBossBags();
				}

		if (!Main.expertMode)
		{
			Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.PinkGel, 31 + Main.rand.Next(8));
			Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.SilverCoin, 50 + Main.rand.Next(6));

				switch (Main.rand.Next(4))
					{
						case 0:
							Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("PinkaPinka"), 1, false, 0, false, false);
						break;

						case 1:
							Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("PinkySword"), 1, false, 0, false, false);
						break;

						case 2:
							Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("PinkyGun"), 1, false, 0, false, false);
						break;

						case 3:
							Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("PinkiePie"), 1, false, 0, false, false);
						break;
			}}}

		public override void AI()
				{
					npc.TargetClosest(true);
			}}}