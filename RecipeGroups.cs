using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace RecipeGroups;

public class RecipeGroupsLib : Mod{}

public class RecipeGroupsSystem : ModSystem
{
  public override void AddRecipeGroups()
  {
    RecipeGroup.Register( //IronAnvils
      "RecipeGroups:IronAnvils",
      () => Language.GetTextValue("Mods.RecipeGroups.GroupNames.IronAnvils"),
      ItemID.IronAnvil,
      ItemID.LeadAnvil
    );

    RecipeGroup.Register( //MythrilAnvils
      "RecipeGroups:MythrilAnvils",
      () => Language.GetTextValue("Mods.RecipeGroups.GroupNames.MythrilAnvils"),
      ItemID.MythrilAnvil,
      ItemID.OrichalcumAnvil
    );

    RecipeGroup.Register( //AdamantiteForges
      "RecipeGroups:AdamantiteForges",
      () => Language.GetTextValue("Mods.RecipeGroups.GroupNames.AdamantiteForges"),
      ItemID.AdamantiteForge,
      ItemID.TitaniumForge
    );

    RecipeGroup.Register( //Tables
      "RecipeGroups:Tables",
      () => Language.GetTextValue("Mods.RecipeGroups.GroupNames.Tables"),
      ItemID.WoodenTable,
      ItemID.AetheriumTable,
      ItemID.AshWoodTable,
      ItemID.BalloonTable,
      ItemID.BambooTable,
      ItemID.BanquetTable,
      ItemID.Bar,
      ItemID.BlueDungeonTable,
      ItemID.BoneTable,
      ItemID.BorealWoodTable,
      ItemID.BoulderTable,
      ItemID.CactusTable,
      ItemID.CloudTable,
      ItemID.CoralTable,
      ItemID.CrimtaneTable,
      ItemID.CrystalTable,
      ItemID.DemoniteTable,
      ItemID.DynastyTable,
      ItemID.EasterTable,
      ItemID.EbonwoodTable,
      ItemID.FallenStarTable,
      ItemID.FeywoodTable,
      ItemID.FleshTable,
      ItemID.FlinxFurTable,
      ItemID.ForbiddenTable,
      ItemID.FrozenTable,
      ItemID.GlassTable,
      ItemID.GoldenTable,
      ItemID.GothicTable,
      ItemID.GraniteTable,
      ItemID.GreenDungeonTable,
      ItemID.HallowedTable,
      ItemID.HarpyTable,
      ItemID.HoneyTable,
      ItemID.JellyfishTable,
      ItemID.LesionTable,
      ItemID.LibrarianTable,
      ItemID.LihzahrdTable,
      ItemID.LivingWoodTable,
      ItemID.MarbleTable,
      ItemID.MartianTable,
      ItemID.MeteoriteTable,
      ItemID.MoonplateTable,
      ItemID.MushroomTable,
      ItemID.NebulaTable,
      ItemID.ObsidianTable,
      ItemID.OfficeTable,
      ItemID.PalmWoodTable,
      ItemID.PearlwoodTable,
      ItemID.PicnicTable,
      ItemID.PicnicTableWithCloth,
      ItemID.PineTable,
      ItemID.PinkDungeonTable,
      ItemID.PumpkinTable,
      ItemID.RichMahoganyTable,
      ItemID.SandstoneTable,
      ItemID.ShadewoodTable,
      ItemID.SkywareTable,
      ItemID.SlimeTable,
      ItemID.SnowTable,
      ItemID.SolarTable,
      ItemID.SpiderTable,
      ItemID.SpikeTable,
      ItemID.SpookyTable,
      ItemID.StardustTable,
      ItemID.SteampunkTable,
      ItemID.StoneTable,
      ItemID.VortexTable,
      ItemID.WaterTable
    );

    RecipeGroup.Register( //Chairs
      "RecipeGroups:Chairs",
      () => Language.GetTextValue("Mods.RecipeGroups.GroupNames.Chairs"),
      ItemID.WoodenChair,
      ItemID.AetheriumChair,
      ItemID.AshWoodChair,
      ItemID.BalloonChair,
      ItemID.BambooChair,
      ItemID.BarStool,
      ItemID.BlueDungeonChair,
      ItemID.BoneChair,
      ItemID.BorealWoodChair,
      ItemID.BoulderChair,
      ItemID.CactusChair,
      ItemID.CloudChair,
      ItemID.CoralChair,
      ItemID.CrimtaneChair,
      ItemID.CrystalChair,
      ItemID.DemoniteChair,
      ItemID.DynastyChair,
      ItemID.EasterChair,
      ItemID.EbonwoodChair,
      ItemID.FallenStarChair,
      ItemID.FeywoodChair,
      ItemID.FleshChair,
      ItemID.FlinxFurChair,
      ItemID.ForbiddenChair,
      ItemID.FrozenChair,
      ItemID.GlassChair,
      ItemID.GoldenChair,
      ItemID.GothicChair,
      ItemID.GraniteChair,
      ItemID.GreenDungeonChair,
      ItemID.HallowedChair,
      ItemID.HarpyChair,
      ItemID.HoneyChair,
      ItemID.JellyfishChair,
      ItemID.LesionChair,
      ItemID.LibrarianChair,
      ItemID.LihzahrdChair,
      ItemID.LivingWoodChair,
      ItemID.MarbleChair,
      ItemID.MartianHoverChair,
      ItemID.MeteoriteChair,
      ItemID.MoonplateChair,
      ItemID.MushroomChair,
      ItemID.NebulaChair,
      ItemID.ObsidianChair,
      ItemID.OfficeChair,
      ItemID.PalmWoodChair,
      ItemID.PearlwoodChair,
      ItemID.PineChair,
      ItemID.PinkDungeonChair,
      ItemID.PumpkinChair,
      ItemID.RichMahoganyChair,
      ItemID.SandstoneChair,
      ItemID.ShadewoodChair,
      ItemID.SkywareChair,
      ItemID.SlimeChair,
      ItemID.SnowChair,
      ItemID.SolarChair,
      ItemID.SpiderChair,
      ItemID.SpikeChair,
      ItemID.SpookyChair,
      ItemID.StardustChair,
      ItemID.SteampunkChair,
      ItemID.StoneChair,
      ItemID.VortexChair,
      ItemID.WaterChair
    );

    RecipeGroup.Register( //WorkBenches
      "RecipeGroups:Workbenches",
      () => Language.GetTextValue("Mods.RecipeGroups.GroupNames.Workbenches"),
      ItemID.WorkBench,
      ItemID.AetheriumWorkbench,
      ItemID.AshWoodWorkbench,
      ItemID.BalloonWorkbench,
      ItemID.BambooWorkbench,
      ItemID.BlueDungeonWorkBench,
      ItemID.BoneWorkBench,
      ItemID.BorealWoodWorkBench,
      ItemID.BoulderWorkbench,
      ItemID.CactusWorkBench,
      ItemID.CloudWorkbench,
      ItemID.CoralWorkbench,
      ItemID.CrimtaneWorkbench,
      ItemID.CrystalWorkbench,
      ItemID.DemoniteWorkbench,
      ItemID.DynastyWorkBench,
      ItemID.EasterWorkbench,
      ItemID.EbonwoodWorkBench,
      ItemID.FallenStarWorkbench,
      ItemID.FeywoodWorkbench,
      ItemID.FleshWorkBench,
      ItemID.FlinxFurWorkbench,
      ItemID.ForbiddenWorkbench,
      ItemID.FrozenWorkBench,
      ItemID.GlassWorkBench,
      ItemID.GoldenWorkbench,
      ItemID.GothicWorkBench,
      ItemID.GraniteWorkBench,
      ItemID.GreenDungeonWorkBench,
      ItemID.HallowedWorkbench,
      ItemID.HarpyWorkbench,
      ItemID.HoneyWorkBench,
      ItemID.JellyfishWorkbench,
      ItemID.LesionWorkbench,
      ItemID.LibrarianWorkbench,
      ItemID.LihzahrdWorkBench,
      ItemID.LivingWoodWorkBench,
      ItemID.MarbleWorkBench,
      ItemID.MartianWorkBench,
      ItemID.MeteoriteWorkBench,
      ItemID.MoonplateWorkbench,
      ItemID.MushroomWorkBench,
      ItemID.NebulaWorkbench,
      ItemID.ObsidianWorkBench,
      ItemID.OfficeWorkbench,
      ItemID.PalmWoodWorkBench,
      ItemID.PearlwoodWorkBench,
      ItemID.PineWorkbench,
      ItemID.PinkDungeonWorkBench,
      ItemID.PumpkinWorkBench,
      ItemID.RichMahoganyWorkBench,
      ItemID.SandstoneWorkbench,
      ItemID.ShadewoodWorkBench,
      ItemID.SkywareWorkbench,
      ItemID.SlimeWorkBench,
      ItemID.SnowWorkbench,
      ItemID.SolarWorkbench,
      ItemID.SpiderWorkbench,
      ItemID.SpikeWorkbench,
      ItemID.SpookyWorkBench,
      ItemID.StardustWorkbench,
      ItemID.SteampunkWorkBench,
      ItemID.StoneWorkbench,
      ItemID.VortexWorkbench,
      ItemID.WaterWorkbench
    );

    RecipeGroup.Register( //Sinks
      "RecipeGroups:Sinks",
      () => Language.GetTextValue("Mods.RecipeGroups.GroupNames.Sinks"),
      ItemID.WoodenSink,
      ItemID.AetheriumSink,
      ItemID.AshWoodSink,
      ItemID.BalloonSink,
      ItemID.BambooSink,
      ItemID.BlueDungeonSink,
      ItemID.BoneSink,
      ItemID.BorealWoodSink,
      ItemID.BoulderSink,
      ItemID.CactusSink,
      ItemID.CloudSink,
      ItemID.CoralSink,
      ItemID.CrimtaneSink,
      ItemID.CrystalSink,
      ItemID.DemoniteSink,
      ItemID.DynastySink,
      ItemID.EasterSink,
      ItemID.EbonwoodSink,
      ItemID.FallenStarSink,
      ItemID.FeywoodSink,
      ItemID.FleshSink,
      ItemID.FlinxFurSink,
      ItemID.ForbiddenSink,
      ItemID.FrozenSink,
      ItemID.GlassSink,
      ItemID.GoldenSink,
      ItemID.GothicSink,
      ItemID.GraniteSink,
      ItemID.GreenDungeonSink,
      ItemID.HallowedSink,
      ItemID.HarpySink,
      ItemID.HoneySink,
      ItemID.JellyfishSink,
      ItemID.LesionSink,
      ItemID.LibrarianSink,
      ItemID.LihzahrdSink,
      ItemID.LivingWoodSink,
      ItemID.MarbleSink,
      ItemID.MartianSink,
      ItemID.MetalSink,
      ItemID.MeteoriteSink,
      ItemID.MoonplateSink,
      ItemID.MushroomSink,
      ItemID.NebulaSink,
      ItemID.ObsidianSink,
      ItemID.OfficeSink,
      ItemID.PalmWoodSink,
      ItemID.PearlwoodSink,
      ItemID.PineSink,
      ItemID.PinkDungeonSink,
      ItemID.PumpkinSink,
      ItemID.RichMahoganySink,
      ItemID.SandstoneSink,
      ItemID.ShadewoodSink,
      ItemID.SkywareSink,
      ItemID.SlimeSink,
      ItemID.SnowSink,
      ItemID.SolarSink,
      ItemID.SpiderSinkSpiderSinkDoesWhateverASpiderSinkDoes,
      ItemID.SpikeSink,
      ItemID.SpookySink,
      ItemID.StardustSink,
      ItemID.SteampunkSink,
      ItemID.StoneSink,
      ItemID.VortexSink,
      ItemID.WaterSink
    );

    RecipeGroup.Register( //CookingPots
      "RecipeGroups:CookingPots",
      () => Language.GetTextValue("Mods.RecipeGroups.GroupNames.CookingPots"),
      ItemID.CookingPot,
      ItemID.Cauldron
    );

    RecipeGroup.Register( //Tombstones
      "RecipeGroups:Tombstones",
      () => Language.GetTextValue("Mods.RecipeGroups.GroupNames.Tombstones"),
      ItemID.Tombstone,
      ItemID.Obelisk,
      ItemID.Headstone,
      ItemID.GraveMarker,
      ItemID.CrossGraveMarker,
      ItemID.Gravestone,
      ItemID.RichGravestone1,
      ItemID.RichGravestone2,
      ItemID.RichGravestone3,
      ItemID.RichGravestone4,
      ItemID.RichGravestone5
    );

    RecipeGroup.Register( //EvilAltars
      "RecipeGroups:EvilAltars",
      () => Language.GetTextValue("Mods.RecipeGroups.GroupNames.EvilAltars"),
      ItemID.DemonAltar,
      ItemID.CrimsonAltar
    );

    RecipeGroup.Register( //CopperOres
      "RecipeGroups:CopperOres",
      () => Language.GetTextValue("Mods.RecipeGroups.GroupNames.CopperOres"),
      ItemID.CopperOre,
      ItemID.TinOre
    );

    RecipeGroup.Register( //IronOres
      "RecipeGroups:IronOres",
      () => Language.GetTextValue("Mods.RecipeGroups.GroupNames.IronOres"),
      ItemID.IronOre,
      ItemID.LeadOre
    );

    RecipeGroup.Register( //SilverOres
      "RecipeGroups:SilverOres",
      () => Language.GetTextValue("Mods.RecipeGroups.GroupNames.SilverOres"),
      ItemID.SilverOre,
      ItemID.TungstenOre
    );

    RecipeGroup.Register( //GoldOres
      "RecipeGroups:GoldOres",
      () => Language.GetTextValue("Mods.RecipeGroups.GroupNames.GoldOres"),
      ItemID.GoldOre,
      ItemID.PlatinumOre
    );

    RecipeGroup.Register( //EvilOres
      "RecipeGroups:EvilOres",
      () => Language.GetTextValue("Mods.RecipeGroups.GroupNames.EvilOres"),
      ItemID.DemoniteOre,
      ItemID.CrimtaneOre
    );

    RecipeGroup.Register( //CobaltOres
      "RecipeGroups:CobaltOres",
      () => Language.GetTextValue("Mods.RecipeGroups.GroupNames.CobaltOres"),
      ItemID.CobaltOre,
      ItemID.PalladiumOre
    );

    RecipeGroup.Register( //MythrilOres
      "RecipeGroups:MythrilOres",
      () => Language.GetTextValue("Mods.RecipeGroups.GroupNames.MythrilOres"),
      ItemID.MythrilOre,
      ItemID.OrichalcumOre
    );

    RecipeGroup.Register( //AdamantiteOres
      "RecipeGroups:AdamantiteOres",
      () => Language.GetTextValue("Mods.RecipeGroups.GroupNames.AdamantiteOres"),
      ItemID.AdamantiteOre,
      ItemID.TitaniumOre
    );

    RecipeGroup.Register( //CopperBars
      "RecipeGroups:CopperBars",
      () => Language.GetTextValue("Mods.RecipeGroups.GroupNames.CopperBars"),
      ItemID.CopperBar,
      ItemID.TinBar
    );

    RecipeGroup.Register( //EvilBars
      "RecipeGroups:EvilBars",
      () => Language.GetTextValue("Mods.RecipeGroups.GroupNames.EvilBars"),
      ItemID.DemoniteBar,
      ItemID.CrimtaneBar
    );
  }
}