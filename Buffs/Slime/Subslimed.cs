using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using LavaHeights;

namespace LavaHeights.Buffs.Slime
{
    public class Subslimed : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Subslimed");
            Description.SetDefault("Sticky slime makes it hard to move as quick.");
            Main.debuff[Type] = true;
            Main.pvpBuff[Type] = true;
            Main.buffNoSave[Type] = true;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.GetModPlayer<LavaHeightsPlayer>().isSlimed = true;
        }
    }
}
