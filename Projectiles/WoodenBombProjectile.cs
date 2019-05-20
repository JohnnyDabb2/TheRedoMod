using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.DataStructures;
using Terraria.ModLoader;

namespace TheRedoMod.Projectiles
{
	public class WoodenBombProjectile : ModProjectile
	{
		public override void SetDefaults() {
			projectile.width = 15;
			projectile.height = 15;
			projectile.friendly = true;
			projectile.penetrate = -1;
			projectile.timeLeft = 400;
			drawOffsetX = 5;
			drawOriginOffsetY = 5;
		}

			public override bool OnTileCollide(Vector2 oldVelocity) {
				if (projectile.soundDelay == 0) {
					Main.PlaySound(SoundID.CreateTrackable("dd2_explosive_trap_explode").WithVolume(.7f).WithPitchVariance(.5f));
				}
					projectile.soundDelay = 10;
			}

			public override void Kill(int timeLeft) {
			Main.PlaySound(SoundID.Item15, projectile.position);
			int explosionRadius = 3;
	}}}