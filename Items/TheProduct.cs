using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheRedoMod.Items
{
	public class TheProduct : ModItem
	{
		public override void SetStaticDefaults() {
		DisplayName.SetDefault("The Product");
		Tooltip.SetDefault("You feel happy inside.");
		}

		public override void SetDefaults() {
			item.damage = 481;
			item.melee = true;
			item.width = 400;
			item.height = 400;
			item.useTime = 2;
			item.useAnimation = 10;
			item.pick = 2000;
			item.expert = true;
			item.useStyle = 1;
			item.knockBack = 40;
			item.value = 10000;
			item.rare = 3;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;

		}
	}
}