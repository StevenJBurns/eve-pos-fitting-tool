using System;
using System.ComponentModel;
using System.Collections.Generic;

namespace Ara.PFT.Model;

public class StarbaseStructure
{
#region Constructors
  public StarbaseStructure()
  {
  }

#endregion

#region Properties
  public Int32 TypeID
    { get; set; }

  public Int32 InstanceID
    { get; set; }

  public String TypeName
    { get; set; }

  public String CustomName
    { get; set; }

  public Int32 PowerGrid
    { get; set; }

  public Int32 CPU
    { get; set; }

  public bool IsOnline
    { get; set; }

#endregion

#region Methods
#endregion
}
