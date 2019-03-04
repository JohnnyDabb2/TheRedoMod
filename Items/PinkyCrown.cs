using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheRedoMod.Items
{
	public class PinkyCrown : ModItem
	{
		public override void SetStaticDefaults() {
		DisplayName.SetDefault("Pinky Crown");
		Tooltip.SetDefault("Summons Princess Pinky.");
		}

			public override void SetDefaults() {
			item.width = 12;
			item.height = 12;
			item.maxStack = 1;
			item.useAnimation = 15;
			item.useTime = 39;
			item.useStyle = 4;
			item.consumable = true;
			}
		
		public override bool CanUseItem(Player player) {
		
		return !NPC.AnyNPCs(mod.NPCType("PrincessPinky"));
		}
		
		public override bool UseItem(Player player) {
		NPC.SpawnOnPlayer(player.whoAmI, mod.NPCType("PrincessPinky"));
		Main.PlaySound(15, (int)player.position.X, (int)player.position.Y, 0);
		
		return true;
		}
		
		public override void AddRecipes()
        {	
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.GoldCrown);
			recipe.AddIngredient(ItemID.PinkGel, 20);
			recipe.AddTile(26);
			recipe.SetResult(this);
			recipe.AddRecipe();
			
			ModRecipe recipe1 = new ModRecipe(mod);
			recipe1.AddIngredient(ItemID.PlatinumCrown);
			recipe1.AddIngredient(ItemID.PinkGel, 20);
			recipe1.AddTile(26);
			recipe1.SetResult(this);
			recipe1.AddRecipe();
		}
	}
}