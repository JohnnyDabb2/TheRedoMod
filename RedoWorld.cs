using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;
using System.IO;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;

namespace TheRedoMod
{
	public class RedoWorld : ModWorld

	{
		private const int saveVersion = 0;
		public static bool downedPrincessPinky;

		public override TagCompound Save() {
			var downed = new List<string>();

			if (downedPrincessPinky) {
				downed.Add("princessPinky");
			}

			return new TagCompound {
				{"downed", downed},
			};
		}

		public override void Load(TagCompound tag) {
			var downed = tag.GetList<string>("downed");
			downedPrincessPinky = downed.Contains("princessPinky");
		}

		public override void NetReceive(BinaryReader reader) {
			BitsByte Flags = reader.ReadByte();
			downedPrincessPinky = Flags[1];
		}

		public override void NetSend(BinaryWriter writer) {
			BitsByte Flags = new BitsByte();
			Flags[1] = downedPrincessPinky;
			writer.Write(Flags);
	}}}