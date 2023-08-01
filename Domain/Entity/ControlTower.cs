using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Ara.PFT.Model.Map;

namespace Ara.PFT.Model.POS;

public class ControlTower
{
#region Fields
  Int32 typeID;
  Int32 powergrid;
  Int32 cpu;
  Race race;
#endregion

#region Constructors
  public ControlTower()
  {
    this.TypeID = 0;
    this.CustomName = String.Empty;
  }

  public ControlTower(Int32 typeID)
  {
    this.TypeID = typeID;
    this.CustomName = String.Empty;
  }
#endregion

#region Properties
  public Int32 TypeID { get; set; }
  public String CustomName { get; set; }
  public Int32 PowerGrid { get; set; }
  public Int32 CPU { get; set; }
  public MapLocation Location { get; set; }
  public IEnumerable<StarbaseStructure> AttachedStructures { get; set; }
  public bool IsOnline { get; set; }
#endregion

#region Methods
  public static ControlTower CreateNewTower()
    { return new ControlTower(); }

  public static ControlTower CreateTower(Int32 typeID)
  {
  return new ControlTower
    {
    TypeID = typeID,
    CustomName = String.Empty
    };
  }
#endregion
}
