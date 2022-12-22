﻿using MacroTools;
using WarcraftLegacies.Source.Quests.Frostwolf;
using WarcraftLegacies.Source.Setup.FactionSetup;

namespace WarcraftLegacies.Source.Setup.QuestSetup
{
  public static class FrostwolfQuestSetup
  {
    public static void Setup(PreplacedUnitSystem preplacedUnitSystem, ArtifactSetup artifactSetup)
    {
      var frostwolf = FrostwolfSetup.Frostwolf;

      frostwolf.AddQuest(new QuestThunderBluff(preplacedUnitSystem, Regions.ThunderBluff.Rect));
      frostwolf.AddQuest(new QuestRexxar(preplacedUnitSystem));
      frostwolf.AddQuest(new QuestDrektharsSpellbook());
      //frostwolf.AddQuest(new QuestRoyalPlunder(Regions.HighBourne, artifactSetup.ScepterOfTheQueen));
      frostwolf.AddQuest(new QuestFreeNerzhul());
      frostwolf.AddQuest(new QuestWorldShaman());
    }
  }
}