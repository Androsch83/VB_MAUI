Public Class Flyout
  Inherits Microsoft.Maui.Controls.FlyoutPage

  Private flyoutPage As FlyoutMenuPage = New FlyoutMenuPage

  Public Sub New()
    Flyout = flyoutPage

    AddHandler flyoutPage.ListView.ItemSelected, AddressOf OnItemSelected

    If Microsoft.Maui.Devices.DeviceInfo.Platform = Microsoft.Maui.Devices.DevicePlatform.WinUI Then
      FlyoutLayoutBehavior = Microsoft.Maui.Controls.FlyoutLayoutBehavior.Popover
      Microsoft.Maui.Controls.PlatformConfiguration.WindowsSpecific.Page.SetToolbarDynamicOverflowEnabled(Me, False)
    End If

    Detail = New Microsoft.Maui.Controls.NavigationPage(New MainPage)
  End Sub


  Private Sub OnItemSelected(ByVal sender As Object, ByVal e As Microsoft.Maui.Controls.SelectedItemChangedEventArgs)
    Dim item = TryCast(e.SelectedItem, FlyoutPageItem)

    If item IsNot Nothing Then

      Detail = New Microsoft.Maui.Controls.NavigationPage(Activator.CreateInstance(item.TargetType))
      flyoutPage.ListView.SelectedItem = Nothing
      IsPresented = False
    End If
  End Sub



End Class



