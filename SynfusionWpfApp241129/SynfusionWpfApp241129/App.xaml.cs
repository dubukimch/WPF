using Syncfusion.Licensing;
using System.Windows;

public partial class App : Application
{
    protected override void OnStartup(StartupEventArgs e)
    {
        SyncfusionLicenseProvider.RegisterLicense("Ngo9BigBOggjHTQxAR8/V1NDaF1cWWhIfEx1RHxQdld5ZFRHallYTnNWUj0eQnxTdEFiWH1WcnRXRmRVV01wVw==");
        base.OnStartup(e);
    }
}
