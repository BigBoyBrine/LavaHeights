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

namespace LavaHeights
{
    public class LavaHeightsPlayer : ModPlayer
    {
        #region Properties

        public bool isSlimed = false;

        #endregion

        #region Overriden Methods

        public override void ResetEffects()
        {
            isSlimed = false;
        }

        public override void UpdateDead()
        {
            isSlimed = false;
        }

        public override void PreUpdateBuffs()
        {
            if (isSlimed)
            {
                
            }
        }

        public override void DrawEffects(PlayerDrawInfo drawInfo, ref float r, ref float g, ref float b, ref float a, ref bool fullBright)
        {
            if (isSlimed)
            {
                if (Main.rand.NextFloat() < 0.381579f)
                {
                    Dust dust;
                    Vector2 position = Main.LocalPlayer.BottomLeft;
                    dust = Terraria.Dust.NewDustDirect(position, 0, 0, 196, -3f, 0f, 0, new Color(255, 255, 255), 1f);
                    dust.noGravity = true;
                }

            }
        }

        #endregion Overriden Methods

        #region Private Methods

        #endregion Private Methods
    }
}
