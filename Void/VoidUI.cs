using System;
using System.Collections.Generic;
using System.IO;
using Terraria;
using Terraria.GameContent.Dyes;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.UI;
using Terraria.GameContent.UI;
using Terraria.GameContent;
using Terraria.GameContent.UI.Elements;
using Terraria.GameContent.UI.States;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace LavaHeights.Void
{
    internal class VoidUI : UIState
    {
		public UIPanel voidUI;
		public static bool visible = false;
        public override void OnInitialize()
		{
			
			UIPanel voidUI = new UIPanel();
			voidUI.Height.Set(30f, 0f);
			voidUI.Width.Set(100f, 0f);
			voidUI.Left.Set(Main.screenWidth - voidUI.Width.Pixels - 400, 0f);
			voidUI.Top.Set(100f, 0f);
			voidUI.BackgroundColor = new Color(255, 255, 255, 255);
	
			VoidBar voidAmount = new VoidBar(VoidBarMode.voidAmount, 280, 25);
			voidAmount.Height.Set(30f, 0f);
			voidAmount.Width.Set(200f, 0f);
			voidAmount.Left.Set(500f, 0f);
			voidAmount.Top.Set(30f, 0f);
			//voidUI.Append(voidAmount);
			
			base.Append(voidAmount);

		}
		protected override void DrawSelf(SpriteBatch spriteBatch)
		{
			VoidBar voidAmount = new VoidBar(VoidBarMode.voidAmount, 280, 25);
			voidAmount.Left.Set(Main.screenWidth - voidAmount.Width.Pixels - 400, 0f);
			voidAmount.Top.Set(100f, 0f);
			Recalculate();
		}

    }
}
