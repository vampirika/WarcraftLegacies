﻿using MacroTools.Extensions;
using MacroTools.FactionSystem;
using MacroTools.LegendSystem;
using MacroTools.ObjectiveSystem.Objectives.FactionBased;
using MacroTools.ObjectiveSystem.Objectives.LegendBased;
using MacroTools.QuestSystem;
using WarcraftLegacies.Source.Setup.FactionSetup;

namespace WarcraftLegacies.Source.Quests.CrisisSpawn
{
  /// <summary>
  /// With Illidari destroyed, The Twilight Hammer can reveal themselves in the Highlands
  /// </summary>
  public sealed class QuestIllidariDead : QuestData
  {
    /// <inheritdoc/>
    protected override string RewardFlavour => "The Twilight Hammer can reveal themselves in the Twilight Highlands";

    /// <inheritdoc/>
    protected override string RewardDescription => "The Twilight Hammer faction will become available to pick as a crisis";

    /// <summary>
    /// Initializes a new instance of the <see cref="QuestIllidariDead"/> class.
    /// </summary>
    public QuestIllidariDead() : base("Illidari is Defeated",
      "With the Illidari eliminated, The Twiligh Highlands have a raise in activity",
      "ReplaceableTextures\\CommandButtons\\BTNFountainOfLife.blp")
    {
      AddObjective(new ObjectiveFactionDefeated(FelHordeSetup.FelHorde));
      AddObjective(new ObjectiveFactionDefeated(IllidariSetup.Illidari));
      ResearchId = Constants.UPGRADE_R09B_QUEST_COMPLETED_SOUTH_ALLIANCE_OR_ILLIDARI_DEFEATED;
      Required = true;
    }

  }
}