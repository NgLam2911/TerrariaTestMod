using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TestMod.Items {
	public class TestSword : ModItem {
		public override void SetStaticDefaults() {
			Tooltip.SetDefault("Just a test sword");
			DisplayName.SetDefault("Test Sword");
		}

		public override void SetDefaults() {
			Item.damage = 1000000;
			Item.DamageType = DamageClass.Melee;
			Item.shoot = ProjectileID.ChlorophyteBullet;
			Item.shootSpeed = 30;
			Item.width = 40;
			Item.height = 40;
			Item.useTime = 5;
			Item.useAnimation = 5;
			Item.useStyle = ItemUseStyleID.Swing;
			Item.knockBack = 6;
			Item.value = 500000;
			Item.rare = ItemRarityID.Red;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
			Item.maxStack = 1;
			Item.crit = 100;
		}

		public override void AddRecipes() {
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.StoneBlock, 20);
			recipe.AddTile(TileID.WorkBenches);
			recipe.Register();
		}
	}
}