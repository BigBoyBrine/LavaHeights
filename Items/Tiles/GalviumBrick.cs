using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace LavaHeights.Items.Tiles
{
    public class GalviumBrick : ModTile
    {
        public override void SetDefaults()
        {
            TileID.Sets.Ore[Type] = true;
            Main.tileSpelunker[Type] = true;
            Main.tileValue[Type] = 410;
            Main.tileShine2[Type] = true;
            Main.tileShine[Type] = 500;
            Main.tileMergeDirt[Type] = true;
            Main.tileSolid[Type] = true;
            Main.tileBlockLight[Type] = true;

            ModTranslation name = CreateMapEntryName();
            name.SetDefault("GalviumBrick");
            AddMapEntry(new Color(200, 200, 200), name);
            drop = mod.ItemType("GalviumBrick");
            soundType = 21;
            soundStyle = 2;
            mineResist = 4f;
            minPick = 30;
        }
    }
}