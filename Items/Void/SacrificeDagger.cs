using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LavaHeights.Void;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace LavaHeights.Items.Void
{
    public sealed class SacrificeDagger : VoidItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Sacrificial Dagger");
            Tooltip.SetDefault("Thy flesh consumed.");
        }

        public override void SafeSetDefaults()
        {
            item.damage = 10;
            item.useTime = 1;
            item.useAnimation = 10;
            item.useStyle = 3;
            item.autoReuse = true;
            item.knockBack = 10;
        }

        public override bool AltFunctionUse(Player player)
        {
            return true;
        }

        public override bool CanUseItem(Player player)
        {
            if (player.altFunctionUse == 2)
            {
                item.useStyle = 1;
                item.useTime = 20;
                item.useAnimation = 20;
                item.damage = 50;
                item.shoot = ProjectileID.Bee;
                item.mana = 10;
            }
            else
            {
                item.useStyle = 3;
                item.useTime = 40;
                item.useAnimation = 40;
                item.damage = 100;
                item.shoot = 0;
            }
            return base.CanUseItem(player);
        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            return base.Shoot(player, ref position, ref speedX, ref speedY, ref type, ref damage, ref knockBack);
        }
    }
}
