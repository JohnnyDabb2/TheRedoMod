using Terraria;
using Terraria.ID;
using TheRedoMod.Projectiles;
using Terraria.ModLoader;

namespace TheRedoMod.Items
{
	public class PinkyPieYoyo : ModItem{
		
		public override void SetStaticDefaults()
		{
		DisplayName.SetDefault("Pinky Pie");
		Tooltip.SetDefault("How did this happen?");
		}
			public override void SetDefaults() {
			item.useStyle = 5;
			item.width = 24;
			item.height = 24;
			item.useAnimation = 25;
			item.useTime = 25;
			item.shootSpeed = 16f;
			item.knockBack = 2.5f;
			item.damage = 32;
			item.rare = 8;

			item.melee = true;
			item.channel = true;
			item.noMelee = true;
			item.noUseGraphic = true;

			item.UseSound = SoundID.Item1;
			item.value = Item.sellPrice(gold: 1);
			item.shoot = mod.ProjectileType<PinkyPieProjectile>();
		}
		
}}