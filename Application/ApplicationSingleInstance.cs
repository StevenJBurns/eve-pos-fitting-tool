using System;
using System.Reflection;
using Microsoft.VisualBasic.ApplicationServices;

namespace Ara.PFT;

public class ApplicationSingleInstance : WindowsFormsApplicationBase
{
  private Application app;

  public ApplicationSingleInstance()
    { this.IsSingleInstance = true; }

  protected override bool OnStartup(Microsoft.VisualBasic.ApplicationServices.StartupEventArgs eventArgs)
  {
    app = new Application();
    var vmMain = new ViewModel.ApplicationViewModel();

    // Application.Current.Resources.Source = new Uri("/PFT;component/Themes/Generic.xaml", UriKind.Relative);

    Ara.PFT.View.WindowMain winmain = new Ara.PFT.View.WindowMain()
    {
      // Title = "PFT v" + Assembly.GetExecutingAssembly().GetName().Version.ToString(),
      DataContext = vmMain
    };

  app.Run(winmain);
  return false;
  }

  protected override void OnStartupNextInstance(StartupNextInstanceEventArgs eventArgs)
  {
    eventArgs.BringToForeground = true;
    app.MainWindow.Activate();
  }
}
