﻿using System.Collections.Generic;
using MacroTools.Extensions;
using MacroTools.FactionSystem;
using MacroTools.LegendSystem;
using MacroTools.ObjectiveSystem.Objectives.LegendBased;
using MacroTools.QuestSystem;

namespace WarcraftLegacies.Source.Quests.Scourge
{
  public sealed class QuestScouringofLordaeron : QuestData
  {
    private readonly LegendaryHero _uther;

    public QuestScouringofLordaeron(IEnumerable<Capital> capitalTargets, LegendaryHero uther) : base("Scouring of Lordaeron",
      "The Kingdom of Lordaeron must be eliminated to pave the way for the Legion's arrival.",
      "ReplaceableTextures\\CommandButtons\\BTNBaronRivendare.blp")
    {
      _uther = uther;
      foreach (var capital in capitalTargets)
        AddObjective(new ObjectiveCapitalDead(capital));
    }

    /// <inheritdoc/>
    protected override string RewardFlavour =>
      "The capital of Lordaeron has fallen, weakening Lordaeron's Champion.";

    /// <inheritdoc/>
    protected override string RewardDescription => "Uther will lose 25 strength";

    /// <inheritdoc/>
    protected override void OnComplete(Faction completingFaction)
    {
      _uther.Unit?.AddHeroAttributes(-25, 0, 0);
    }
  }
}