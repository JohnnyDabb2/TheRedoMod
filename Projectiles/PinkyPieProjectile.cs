using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheRedoMod.Projectiles
{
	public class PinkyPieProjectile : ModProjectile
	{
			public override void SetStaticDefaults()
			{
			ProjectileID.Sets.YoyosLifeTimeMultiplier[projectile.type] = -1f;
			ProjectileID.Sets.YoyosMaximumRange[projectile.type] = 200f;
			ProjectileID.Sets.YoyosTopSpeed[projectile.type] = 9.5f;
			}

			public override void SetDefaults() {
			projectile.extraUpdates = 0;
			projectile.width = 16;
			projectile.height = 16;
			projectile.aiStyle = 99;
			projectile.friendly = true;
			projectile.penetrate = -1;
			projectile.melee = true;
			projectile.scale = 1f;
}}}