using Android.App;
using Android.Runtime;

namespace Platform_Code;

[Application]
public class MainApplication : MauiApplication
{
	public MainApplication(IntPtr handle, JniHandleOwnership ownership)
		: base(handle, ownership)
	{
	}

    protected override MauiApp CreateMauiApp() => VB_UI_Code.MauiProgramm.CreateMauiApp();
}
