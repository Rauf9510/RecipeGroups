# Recipe Groups

**Recipe Groups** es una biblioteca para Terraria que añade grupos de objetos predefinidos para utilizar en las recetas.

El mod permite a los desarrolladores crear recetas en las que se puede utilizar cualquier objeto del grupo correspondiente en lugar de un objeto específico. Esto simplifica la creación de recetas y evita tener que duplicarlas para incluir objetos alternativos.

## Características

- **Grupos de objetos:** grupos predefinidos de objetos alternativos para utilizar en las recetas.
- **Estaciones de fabricación:** grupos de mesas, bancos de trabajo, yunques, fregaderos y otras estaciones.
- **Mobiliario:** grupos de sillas y otros muebles.
- **Minerales y lingotes:** grupos de minerales y lingotes que tienen en cuenta sus variantes alternativas.
- **Localización:** compatibilidad con todos los idiomas de Terraria para los nombres de los grupos.
- **Facilidad de desarrollo:** posibilidad de utilizar grupos ya preparados en lugar de crear soluciones similares propias.

## Uso

La biblioteca está destinada principalmente a los desarrolladores de mods. Otros mods pueden utilizar los grupos proporcionados por Recipe Groups en sus recetas, lo que permite a los jugadores usar objetos alternativos sin necesidad de modificar la receta.

### Ejemplo de uso

Para añadir grupos de objetos a una receta, utiliza el método `AddRecipeGroup()` dentro de la cadena de creación de la receta.

Por ejemplo, el siguiente código crea una receta que requiere un yunque de hierro o de plomo y 10 unidades de madera:

```cs
public override void AddRecipes()
{
  CreateRecipe()
    .AddIngredient(ItemID.Wood, 10)
    .AddRecipeGroup("RecipeGroups:IronAnvils")
    .Register();
}
```

En este ejemplo:

- `AddIngredient()` añade 10 unidades de madera como ingrediente normal.
- `AddRecipeGroup()` añade el grupo de yunques de hierro, lo que permite utilizar cualquier objeto incluido en ese grupo.
- `Register()` completa la creación y registra la receta.

Por lo tanto, para completar la receta se necesitarán 10 unidades de madera y uno de los yunques del grupo `RecipeGroups:IronAnvils` (un yunque de hierro o de plomo).

### Otros ejemplos de grupos

```cs
.AddRecipeGroup("RecipeGroups:Chairs")
.AddRecipeGroup("RecipeGroups:Workbenches")
.AddRecipeGroup("RecipeGroups:CopperBars")
.AddRecipeGroup("RecipeGroups:IronOres")
.AddRecipeGroup("RecipeGroups:Sinks")
```

La lista completa de grupos disponibles se encuentra en el código fuente de la biblioteca Recipe Groups.

## Nota

Terraria ya incluye algunos grupos de objetos integrados, como `IronBar` y `Wood`. Recipe Groups los complementa con sus propios grupos, que no están incluidos entre los grupos estándar.

## Compatibilidad

Recipe Groups está desarrollado para Bunny-Loader y está destinado a ser utilizado como biblioteca por otros mods.

---

**Recipe Groups** es un conjunto unificado de grupos de objetos predefinidos que simplifica el desarrollo de recetas.
