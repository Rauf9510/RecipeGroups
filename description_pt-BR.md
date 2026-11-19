# Recipe Groups

**Recipe Groups** é uma biblioteca para Terraria que adiciona grupos de itens predefinidos para serem usados em receitas.

O mod permite que desenvolvedores criem receitas nas quais qualquer item do grupo correspondente pode ser usado no lugar de um item específico. Isso simplifica a criação de receitas e elimina a necessidade de duplicá-las para itens alternativos.

## Recursos

- **Grupos de itens:** grupos predefinidos de itens alternativos para uso em receitas.
- **Estações de criação:** grupos de mesas, bancadas de trabalho, bigornas, pias e outras estações.
- **Móveis:** grupos de cadeiras e outros itens de mobília.
- **Minérios e barras:** grupos de minérios e barras que incluem suas variantes alternativas.
- **Localização:** suporte a todos os idiomas de Terraria para os nomes dos grupos.
- **Facilidade de desenvolvimento:** possibilidade de usar grupos prontos em vez de criar soluções semelhantes próprias.

## Uso

A biblioteca é destinada principalmente a desenvolvedores de mods. Outros mods podem usar os grupos fornecidos por Recipe Groups em suas receitas, permitindo que os jogadores utilizem itens alternativos sem precisar alterar a própria receita.

### Exemplo de uso

Para adicionar grupos de itens a uma receita, use o método `AddRecipeGroup()` dentro da cadeia de criação da receita.

Por exemplo, o código a seguir cria uma receita que requer uma bigorna de ferro ou de chumbo e 10 unidades de madeira:

```cs
public override void AddRecipes()
{
  CreateRecipe()
    .AddIngredient(ItemID.Wood, 10)
    .AddRecipeGroup("RecipeGroups:IronAnvils")
    .Register();
}
```

Neste exemplo:

- `AddIngredient()` adiciona 10 unidades de madeira como ingrediente comum.
- `AddRecipeGroup()` adiciona o grupo de bigornas de ferro, permitindo usar qualquer item que faça parte desse grupo.
- `Register()` conclui a criação e registra a receita.

Assim, para fabricar o item, serão necessárias 10 unidades de madeira e uma das bigornas compatíveis do grupo `RecipeGroups:IronAnvils` (bigorna de ferro ou de chumbo).

### Outros exemplos de grupos

```cs
.AddRecipeGroup("RecipeGroups:Chairs")
.AddRecipeGroup("RecipeGroups:Workbenches")
.AddRecipeGroup("RecipeGroups:CopperBars")
.AddRecipeGroup("RecipeGroups:IronOres")
.AddRecipeGroup("RecipeGroups:Sinks")
```

A lista completa de grupos disponíveis pode ser encontrada no código-fonte da biblioteca Recipe Groups.

## Observação
Terraria já possui alguns grupos de itens integrados, como `IronBar` e `Wood`. Recipe Groups complementa esses grupos com seus próprios grupos, que não estão entre os grupos padrão.

## Compatibilidade

Recipe Groups foi desenvolvido para Bunny-Loader e destina-se ao uso por outros mods como biblioteca.

---

**Recipe Groups** — um conjunto unificado de grupos de itens predefinidos que simplifica o desenvolvimento de receitas.
