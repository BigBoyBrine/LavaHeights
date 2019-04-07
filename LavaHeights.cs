using LavaHeights.Void;
using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;
using Terraria.UI;

namespace LavaHeights
{
	public class LavaHeights : Mod
	{
        internal UserInterface customResources;
        internal VoidUI voidUI;

        public override void Load()
        {
            if (!Main.dedServ)
            {
                customResources = new UserInterface();
                voidUI = new VoidUI();
                VoidUI.visible = true;
                customResources.SetState(voidUI);

            }
        }

        public override void ModifyInterfaceLayers(List<GameInterfaceLayer> layers)
        {
            int mouseTextIndex = layers.FindIndex(layer => layer.Name.Equals("Vanilla: Mouse Text"));
            if (mouseTextIndex != -1)
            {
                layers.Insert(mouseTextIndex, new LegacyGameInterfaceLayer(
                    "LavaHeights: Void Meter",
                    delegate {
                        if (VoidUI.visible)
                        {
                            voidUI.Draw(Main.spriteBatch);
                        }
                        return true;
                    },
                    InterfaceScaleType.UI)
                );
            }
        }
	}
}
