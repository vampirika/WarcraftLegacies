﻿using MacroTools.FactionSystem;
using MacroTools.ObjectiveSystem.Objectives;
using MacroTools.QuestSystem;
using WarcraftLegacies.Source.Setup;
using WarcraftLegacies.Source.Setup.FactionSetup;
using WarcraftLegacies.Source.Setup.Legends;
using static War3Api.Common;

namespace WarcraftLegacies.Source.Quests.Naga
{
  public sealed class QuestFrozenThrone : QuestData
  {
    public QuestFrozenThrone() : base("A Symphony of Frost and Flame",
      "Kil'jaeden has ordered Illidan to destroy the Frozen Throne, and he shall obey.",
      "ReplaceableTextures\\CommandButtons\\BTNMetamorphosis.blp")
    {
      AddObjective(new ObjectiveKillUnit(LegendScourge.LegendLichking.Unit));
      AddObjective(new ObjectiveResearch(Constants.UPGRADE_R063_PATH_OF_EXILE_NAGA, Constants.UNIT_N0C9_TEMPLE_OF_TIDES_NZOTH));
      Global = true;
    }

    protected override string CompletionPopup =>
      "As a reward for his mission, Illidan and his followers have been welcomed into the ranks of the Burning Legion";

    protected override string RewardDescription => "The Illidari team will join the Burning Legion in their team";
    
    protected override void OnComplete(Faction completingFaction)
    {
     
    }
  }
}