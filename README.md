# Recipe Groups

<p align="center">
  <img src="banner.png" alt="Recipe Groups Banner">
</p>

<p align="center">
  A recipe group library for Terraria mod developers.
</p>

---

## Overview

**Recipe Groups** is a library mod for Terraria that provides ready-to-use groups of alternative items for crafting recipes.

In Terraria, certain items serve the same purpose but have different variants. For example, several types of crafting stations, furniture, ores, and bars can be used interchangeably.

Instead of creating separate recipes for every alternative item, Recipe Groups allows mod developers to use a single recipe group that accepts any registered item belonging to that group.

This makes recipe definitions cleaner, reduces unnecessary duplication, and makes recipes more flexible.

## Features

- **Ready-to-Use Groups:** A collection of predefined groups covering various item categories.
- **Alternative Ingredients:** Allow recipes to accept different items that serve the same purpose.
- **Simplified Recipe Creation:** Reduce the need to create multiple recipes for alternative ingredients.
- **Developer-Friendly:** Designed as a library for integration with other mods.
- **Multilingual Support:** Localized group names in seven languages.

## Available Groups

Recipe Groups currently provides 20 predefined recipe groups across several item categories.

### Crafting Stations & Furniture

- `IronAnvils`
- `MythrilAnvils`
- `AdamantiteForges`
- `Tables`
- `Chairs`
- `Workbenches`
- `Sinks`
- `CookingPots`
- `Tombstones`
- `EvilAltars`

### Ores

- `CopperOres`
- `IronOres`
- `SilverOres`
- `GoldOres`
- `EvilOres`
- `CobaltOres`
- `MythrilOres`
- `AdamantiteOres`

### Bars

- `CopperBars`
- `EvilBars`

Each group allows recipes to accept alternative items belonging to the corresponding category.

## For Developers

Recipe Groups is intended to be used as a library dependency by other Terraria mods.

It provides predefined recipe groups that developers can reference when registering their own recipes.

Using these groups helps avoid unnecessary recipe duplication and makes crafting requirements more consistent across different mods.

The library is designed to make it easier for mod developers to support alternative Terraria items without having to register and maintain the same groups themselves.

## Usage Examples

Recipe Groups can be used in crafting recipes through Terraria's
`AddRecipeGroup()` method.

### Using a Recipe Group

For example, to allow any registered table to be used as a crafting
ingredient:

``` cs
public override void AddRecipes()
{
    CreateRecipe()
        .AddRecipeGroup("RecipeGroups:Tables")
        .Register();
}
```

### Using Multiple Recipe Groups

You can also use multiple recipe groups in a single recipe:

``` cs
public override void AddRecipes()
{
    CreateRecipe()
        .AddRecipeGroup("RecipeGroups:IronAnvils")
        .AddRecipeGroup("RecipeGroups:Tables")
        .Register();
}
```

### Specifying Ingredient Amounts

You can specify how many items from a recipe group are required:

``` cs
public override void AddRecipes()
{
    CreateRecipe()
        .AddRecipeGroup("RecipeGroups:CopperBars", 5)
        .Register();
}
```

### Recipe Group Keys

Each recipe group uses a unique key in the following format:

`RecipeGroups:GroupName`

For example:

-   `RecipeGroups:Tables`
-   `RecipeGroups:Chairs`
-   `RecipeGroups:IronAnvils`
-   `RecipeGroups:CopperOres`
-   `RecipeGroups:CopperBars`

These keys can be passed directly to `AddRecipeGroup()`.

## Localization

Recipe Groups supports seven languages:

| Language | Locale |
|---|---|
| 🇺🇸 English | `en-US` |
| 🇩🇪 Deutsch | `de-DE` |
| 🇮🇹 Italiano | `it-IT` |
| 🇫🇷 Français | `fr-FR` |
| 🇪🇸 Español | `es-ES` |
| 🇷🇺 Русский | `ru-RU` |
| 🇧🇷 Português brasileiro | `pt-BR` |

Group names are localized to make the library accessible to developers and players using different game languages.

## Download

You can find the latest available version of Recipe Groups in the [Releases](../../releases) section.

Each release contains the corresponding compiled mod package.

## Compatibility

Recipe Groups is developed for Terraria using Bunny-Loader.

Make sure to use a version compatible with your Bunny-Loader installation.

## License

Recipe Groups is distributed under the **MIT License**.

You are free to use, modify, and distribute this project in accordance with the license terms.

See the [LICENSE](license.md) file for the full license text.

---

<p align="center">
  Made for the Terraria modding community.
</p>
