using System;
using TheRedoMod;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria;

namespace TheRedoMod
{
	public class TheRedoMod : Mod
	{
		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.Cloud, 70);
			recipe.AddIngredient(ItemID.PiggyBank);
			recipe.AddTile(412);
			recipe.SetResult(3213);
			recipe.AddRecipe();
		}
			public override void PostSetupContent() {
			Mod bossChecklist = ModLoader.GetMod("BossChecklist");
			if (bossChecklist != null) {
				bossChecklist.Call("AddBossWithInfo", "Princess Pinky", 5.2f, (Func<bool>)(() => RedoWorld.downedPrincessPinky), "Use a [i:" + ItemType("PinkyCrown") + "]");
	}}}}