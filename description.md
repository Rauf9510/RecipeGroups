# Recipe Groups

**Recipe Groups** is a library for Terraria that provides ready-made item groups for use in recipes.

The mod allows developers to create recipes that accept any item from a corresponding group instead of requiring one specific item. This simplifies recipe creation and eliminates the need to create duplicate recipes for alternative items.

## Features

- **Item groups:** ready-made groups of alternative items for use in recipes.
- **Crafting stations:** groups for tables, workbenches, anvils, sinks, and other crafting stations.
- **Furniture:** groups for chairs and other furniture items.
- **Ores and bars:** groups for ores and bars, including their alternative variants.
- **Localization:** support for all Terraria languages in group names.
- **Simplified development:** use ready-made groups instead of creating similar solutions yourself.

## Usage

This library is primarily intended for mod developers. Other mods can use the groups provided by Recipe Groups in their recipes, allowing players to use alternative items without changing the recipe itself.

### Usage example

To add an item group to a recipe, use the `AddRecipeGroup()` method in the recipe creation chain.

For example, the following code creates a recipe that requires either an Iron Anvil or a Lead Anvil, along with 10 Wood:

```cs
public override void AddRecipes()
{
  CreateRecipe()
    .AddIngredient(ItemID.Wood, 10)
    .AddRecipeGroup("RecipeGroups:IronAnvils")
    .Register();
}
```

In this example:

- `AddIngredient()` adds 10 Wood as a regular ingredient.
- `AddRecipeGroup()` adds the Iron Anvils group, allowing either item in that group to be used.
- `Register()` completes and registers the recipe.

Therefore, the recipe requires 10 Wood and one of the anvils included in the `RecipeGroups:IronAnvils` group (an Iron Anvil or a Lead Anvil).

### Other group examples

```cs
.AddRecipeGroup("RecipeGroups:Chairs")
.AddRecipeGroup("RecipeGroups:Workbenches")
.AddRecipeGroup("RecipeGroups:CopperBars")
.AddRecipeGroup("RecipeGroups:IronOres")
.AddRecipeGroup("RecipeGroups:Sinks")
```

The complete list of available groups can be found in the Recipe Groups source code.

## Note

Terraria already includes some built-in item groups, such as `IronBar` and `Wood`. Recipe Groups supplements these with its own groups that are not available among the built-in ones.

## Compatibility

Recipe Groups is designed for Bunny-Loader and is intended to be used as a library by other mods.

---

**Recipe Groups** provides a collection of ready-made item groups that simplifies recipe development.
