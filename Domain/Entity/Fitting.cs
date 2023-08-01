using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Ara.PFT.Model.Map;

namespace Ara.PFT.Model.POS;

public class Fitting
{
#region Fields
  private ControlTower tower;
  private ObservableCollection<StarbaseStructure> attachedStructures;
  private MapLocation location;

#endregion

#region Constructors
  public Fitting(ControlTower tower, IEnumerable<StarbaseStructure> attachedStructures)
  {
  }

  public Fitting(Fitting originalPOS)
  {
  }

#endregion
}
