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
		npc.netAlways = true;
}}}