Imports Microsoft.Maui.Hosting

Public Class AppVB
  Inherits Microsoft.Maui.Controls.Application

  Public Sub New()

    MainPage = New Flyout
  End Sub
End Class

Public Class MauiProgramm

  Public Shared Function CreateMauiApp() As Microsoft.Maui.Hosting.MauiApp
    Dim builder = Microsoft.Maui.Hosting.MauiApp.CreateBuilder()
    builder.UseMauiApp(Of AppVB)().ConfigureFonts(Sub(fonts)
                                                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular")
                                                  End Sub)
    Return builder.Build()
  End Function

End Class
