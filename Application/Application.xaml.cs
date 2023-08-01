using System;
using System.Windows;
using System.Reflection;

namespace Ara.PFT;

public partial class Application : System.Windows.Application
{
  public Application() : base()
  {
  }

  protected override void OnStartup(System.Windows.StartupEventArgs e)
  {
    base.OnStartup(e);
    // InitializeStaticData();
  }

  private void InitializeStaticData()
  {
    // Ara.PFT.Data.StaticData dal = new Data.StaticData();
  }
}
