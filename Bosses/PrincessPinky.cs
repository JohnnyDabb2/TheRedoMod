using System;
using Microsoft.Xna.Framework;
using Terraria.Localization;
using Terraria;
using Terraria.ID;
using TheRedoMod;
using Terraria.ModLoader;

namespace TheRedoMod.Bosses
{
	[AutoloadBossHead]
		public class PrincessPinky : ModNPC
{
	public override void SetDefaults()
	{
		npc.lifeMax = 4000;
		npc.damage = 70;
		npc.defense = 40;
		npc.aiStyle = 1;
		npc.width = 61;
		npc.height = 58;
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
			npc.lifeMax = (int)(npc.lifeMax * 0.78f * bossLifeScale);
			npc.damage = (int)(npc.damage * 0.6f);
		}

	public override void NPCLoot()
	{
		if (Main.expertMode)
				{
				npc.DropBossBags();
				}

		if (!Main.expertMode)
		{
			Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.PinkGel, 31 + Main.rand.Next(8));
			Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.SilverCoin, 50 + Main.rand.Next(6));

					if (Main.rand.Next(14) == 0)
						{
							Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("PrincessPinkyMask"));
					}}
				
				if (Main.rand.Next(10) == 0)
					{
						Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("PrincessPinkyTrophy"));
				}

		switch (Main.rand.Next(3))
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
		}}

		public override void AI()
			{
				npc.TargetClosest(true);
			}}}