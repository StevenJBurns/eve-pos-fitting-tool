using System;

namespace Ara.PFT;

class ApplicationEntry
{
  [STAThread]
  public static void Main(String[] args)
  {
    ApplicationSingleInstance singleinstanceapp = new ApplicationSingleInstance();
    singleinstanceapp.Run(args);
  }
}
