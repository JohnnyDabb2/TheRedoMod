using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using TheRedoMod;

namespace TheRedoMod.Items.Accessories
{
	public class DefensiveEmblem : ModItem
		{
			public override void SetStaticDefaults() {
				Tooltip.SetDefault("15% increased defensive damage");
			}

			public override void SetDefaults() {
				item.rare = 4;
				item.accessory = true;
			}

			public override void UpdateAccessory(Player player, bool hideVisual) {
				RedoPlayer modPlayer = player.GetModPlayer<RedoPlayer>(mod);
				modPlayer.DefensiveDamage += 0.15f;
		}

			public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(this);
			recipe.AddIngredient(548, 5);
			recipe.AddIngredient(549, 5);
			recipe.AddIngredient(547, 5);
			recipe.AddTile(114);
			recipe.SetResult(935);
			recipe.AddRecipe();
	}}}