using Terraria.ID;
using Terraria.ModLoader;

namespace LavaHeights.Items.Ores
{
    public class GalviumOre : ModItem
    {
        public override void SetStaticDefaults()
        {
            ItemID.Sets.SortingPriorityMaterials[item.type] = 100;
        }

        public override void SetDefaults()
        {
            item.useStyle = 1;
            item.useTurn = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.autoReuse = true;
            item.maxStack = 999;
            item.consumable = true;
            item.createTile = mod.TileType("GalviumOre");
            item.width = 18;
            item.height = 18;
            item.value = 100;
        }
    }
}