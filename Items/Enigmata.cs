using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheRedoMod.Items
{
	public class Enigmata : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Enigmata");
			Tooltip.SetDefault("Forged with the power of many dying souls.");
		}
		public override void SetDefaults()
		{
			item.damage = 322;
			item.melee = true;
			item.width = 800;
			item.height = 800;
			item.useTime = 2;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 10;
			item.value = 40;
			item.rare = 3;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
}}}