using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Ara.PFT.Model.Map;

public sealed class MapRoot
  {
  private static readonly MapRoot instance = new MapRoot();
  IEnumerable<Region> regions;

  private MapRoot()
    {
    }

  public static MapRoot Instance
    { get { return instance; } }

  public IEnumerable<Region> Regions
    { get { return regions; } }		
  }
