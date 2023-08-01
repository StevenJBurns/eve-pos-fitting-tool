using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Xml;

namespace Ara.PFT.Model.Map;

/// <summary>Represents a Region of the EVE universe</summary>
public sealed class Region : IMapComponent
  {
  #region Fields
  private String id;
  private String name;
  private SpaceType spacetype;
  private IEnumerable<Constellation> constellations;
  #endregion

  # region Constructor

  /// <summary>Constructor</summary>
  /// <param name="src"></param>
  public Region(String id, String name)
    {
    this.id = id;
    this.name = name;
    }

  #endregion

  # region Properties

  /// <summary>Gets the ID of this Region</summary>
  public String ID
    {
    get {return id;}
    //private set;
    }

  /// <summary>Gets name of this Region</summary>
  public String Name
    {
    get { return name; }
    //private set;
    }

  public SpaceType Space
    { get { return spacetype; }}

  public String ParentID
    { get {return String.Empty;}}

  /// <summary>Gets the child Constellations of this Region</summary>
  public ReadOnlyCollection<Constellation> Constellations
    { get; private set; }

  #endregion

  # region Public Methods

  public static IEnumerable<Constellation> GetConstellations(XmlReader source)
    {
    source.Read();
    source.MoveToContent();

      if (source.LocalName.Equals("Constellation"))
        yield return new Constellation(source.GetAttribute("id"), source.GetAttribute("name"));			
    }

  #endregion

  # region Override Methods

  /// <summary>Gets the name of this object</summary>
  public override string ToString()
    { return Name; }

  #endregion
  }
