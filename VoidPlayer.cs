using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Terraria;
using Terraria.DataStructures;
using Terraria.GameInput;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;

namespace LavaHeights
{
	
	public class VoidPlayer : ModPlayer
	{
		public int voidMeterMax = 100;
		private const int voidCrystalMax = 10;
		public override TagCompound Save() {
				
			return new TagCompound {
				
				{"voidMeterMax", voidMeterMax},
				};
		}

		public override void Load(TagCompound tag) 
		{
			voidMeterMax = tag.GetInt("voidMeterMax");
		
		}
		
		public float voidMeter = 0; 
		public float voidRegen = 0; 
		public float voidCost = 1f; 
		public float voidSpeed = 1f; 
		public int voidMeterMax2 = 0;
		
		public static VoidPlayer ModPlayer(Player player) {
			return player.GetModPlayer<VoidPlayer>();
		}

		public float voidDamage = 1f;
		public float voidKnockback;
		public int voidCrit;

		public override void ResetEffects() {
			ResetVariables();
		}

		public override void UpdateDead() {
			ResetVariables();
		}

		private void ResetVariables() {
			
			voidDamage = 1f;
			
			if(voidMeter < 0)
			{
			player.lifeRegen += (int)(voidMeter * 0.7f);
			voidMeter += -player.lifeRegen * 0.02f;
			voidDamage -= voidMeter * 0.025f;
			voidDamage += (player.statLifeMax2 - player.statLife) * 0.01f;
			}
			
			voidSpeed = 1f; 
			voidCost = 1; 
			voidMeter += 0.03f + voidRegen;
			voidMeterMax2 = voidMeterMax;
			
			if(voidMeter > voidMeterMax2)
				voidMeter = voidMeterMax2;
			{
			}
			
			voidKnockback = 0f;
			voidCrit = 0;
			voidRegen = 0;
		}
		public int voidMana;
		public override void GetWeaponDamage(Item item, ref int damage) 
		{
			int voidMana = item.mana;
			voidMana = (int)(voidMana * VoidPlayer.ModPlayer(player).voidCost);
		}
		public override float UseTimeMultiplier(Item item){
			return voidSpeed;
		}
		public override bool Shoot(Item item, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack) 
		{
			if(!item.melee && !item.ranged && !item.magic && !item.summon && !item.thrown && item.mana > 0) //Checking if item is a void item (possibly temporary until a more optimal check is put in place)
			{
				player.statMana += item.mana;
				
				int voidMana = item.mana;
				voidMana = (int)(voidMana * VoidPlayer.ModPlayer(player).voidCost);
				
				int chargeInt = (int)VoidPlayer.ModPlayer(player).voidMeter;
				string text = chargeInt.ToString();;
				//Main.NewText("Void = " + text, 195, 145, 0);
					
				VoidPlayer.ModPlayer(player).voidMeter -= voidMana;
				if(VoidPlayer.ModPlayer(player).voidMeter < 0)
				{
				player.statLife -= voidMana;
					if(player.statLife < 1)
					{
						player.statLife = 1;
					}
				}
				
				chargeInt = (int)VoidPlayer.ModPlayer(player).voidMeter;
				text = chargeInt.ToString();;
				//Main.NewText("Void = " + text, 195, 145, 0);
				if(item.shoot != 10)
				{
				return true;
				}
				return false;
			}
			return true;
		}
	}
}
