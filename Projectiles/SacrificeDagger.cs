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

namespace LavaHeights.Projectiles
{
    public class SacrificeDagger : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.Name = "The Sacrificial Dagger";
            projectile.width = 30;
            projectile.height = 30;
            projectile.light = 0.15f;
            projectile.aiStyle = 3;
            projectile.friendly = true;
            projectile.penetrate = 10;
            projectile.melee = true;
            projectile.extraUpdates = 1;
        }
    }
}
