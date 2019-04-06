using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.ModLoader;

namespace LavaHeights.Void
{
	public abstract class VoidItem : ModItem
	{
		//public int voidUsage = 0;
		public virtual void SafeSetDefaults() {
		}
		public sealed override void SetDefaults() {
			item.shoot = 10; //placeholder projectile 
			
			SafeSetDefaults();
			item.melee = false;
			item.ranged = false;
			item.magic = false;
			item.thrown = false;
			item.summon = false;
		}

		public int voidMana;
		public override void GetWeaponDamage(Player player, ref int damage) 
		{
			voidMana = item.mana;
			voidMana = (int)(voidMana * VoidPlayer.ModPlayer(player).voidCost);
			damage = (int)(damage * VoidPlayer.ModPlayer(player).voidDamage + 5E-06f);
			//Main.NewText("Void", 195, 145, 0);
		}

		
		public override void GetWeaponKnockback(Player player, ref float knockback) 
		{
			knockback = knockback + VoidPlayer.ModPlayer(player).voidKnockback;
		}

		public override void GetWeaponCrit(Player player, ref int crit) 
		{
			
			crit = crit + VoidPlayer.ModPlayer(player).voidCrit + 4;
		}
		public override bool UseItem(Player player) 
		{
				
			return true;
		}
		public override void ModifyTooltips(List<TooltipLine> tooltips) {
			
			//Player player = Main.player[localPlayer];
			TooltipLine tt = tooltips.FirstOrDefault(x => x.Name == "Damage" && x.mod == "Terraria");
			if (tt != null) 
			{
			string[] splitText = tt.text.Split(' ');
				string damageValue = splitText.First();
				string damageWord = splitText.Last();
				tt.text = damageValue + " void " + damageWord;
				
			}
				
			string voidManaText = voidMana.ToString();
			TooltipLine tt2 = tooltips.FirstOrDefault(x => x.Name == "UseMana" && x.mod == "Terraria");
			if (tt2 != null) 
			{
			string[] splitText = tt2.text.Split(' ');
				//string damageValue = splitText.First();
				//string damageWord = splitText.Last();
				tt2.text = "Consumes " + voidManaText + " void";
				
			}
		
	}
}
}
