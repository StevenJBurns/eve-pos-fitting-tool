using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Ara.PFT.Model.Map;

/// <summary>Represents a Constellation of the EVE universe</summary>
public sealed class Constellation : IMapComponent
{
#region Fields
  private String id;
  private String name;
  private String parentRegionID;
  private IList<SolarSystem> solarsystems;
#endregion

#region Constructor
  /// <summary>Constructor/// </summary>
  public Constellation(String id, String name)
  {
  this.id = id;
  this.name = name;

  FullLocation = String.Format("{0} ► {1}", Region.Name, Name);
  }

#endregion

#region Properties
  /// <summary>Gets this object's ID</summary>
  public String ID { get; private set; }

  /// <summary>Gets this object's name</summary>
  public string Name { get; private set; }

  ///<summary>Gets the region where this constellation is located</summary>
  public Region Region { get; private set; }

  /// <summary>Gets something like Heimatar > Constellation</summary>
  public string FullLocation { get; private set; }
	
#endregion

#region Helper Methods
#endregion

#region Override Methods
  /// <summary>Gets the name of this object</summary>
  public override string ToString()
    { return Name; }
#endregion
}
