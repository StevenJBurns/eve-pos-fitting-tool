using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Ara.PFT.Model.Map;

/// <summary>Represents a Solar System of the EVE universe.</summary>
public sealed class SolarSystem : IMapComponent
{
#region Fields
  private UInt32 id;
  private String name;
  private UInt32 parentConstellationID;
#endregion

#region Constructor
  /// <summary>Constructor/// </summary>
  public SolarSystem(UInt32 id, String name, UInt32 parentID)
  {
    this.id = id;
    this.name = name;
    this.parentConstellationID = parentID;
  }
#endregion

#region Proprties
  public String ID
    { get; private set; }

  public String Name
    { get; private set; }

  public String ParentID
    { get { return String.Empty; } }

  public Constellation Constellation
    { get; private set; }

  public Int32 TrueSecurityRating
    { get; private set; }
#endregion
}
