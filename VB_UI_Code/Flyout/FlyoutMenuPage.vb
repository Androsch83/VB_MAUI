Public Class FlyoutMenuPage
  Inherits Microsoft.Maui.Controls.ContentPage

  Private ReadOnly m_listView As Microsoft.Maui.Controls.ListView

  Public ReadOnly Property ListView As Microsoft.Maui.Controls.ListView
    Get
      Return m_listView
    End Get
  End Property

  Public Sub New()
    Dim flyoutPageItems = New List(Of FlyoutPageItem) From {
      New FlyoutPageItem With {.Title = "Page1", .TargetType = GetType(Page1)},
      New FlyoutPageItem With {.Title = "Page2", .TargetType = GetType(Page2)}
      }
    m_listView = New Microsoft.Maui.Controls.ListView With {
        .ItemsSource = flyoutPageItems,
        .ItemTemplate = New Microsoft.Maui.Controls.DataTemplate(Function()
                                                                   Dim grid = New Microsoft.Maui.Controls.Grid With {.Padding = New Microsoft.Maui.Thickness(5, 10)}
                                                                   grid.ColumnDefinitions.Add(New Microsoft.Maui.Controls.ColumnDefinition With {.Width = Microsoft.Maui.GridLength.Auto})
                                                                   Dim label = New Microsoft.Maui.Controls.Label With {.HorizontalOptions = Microsoft.Maui.Controls.LayoutOptions.Start}
                                                                   label.SetBinding(Microsoft.Maui.Controls.Label.TextProperty, New Microsoft.Maui.Controls.Binding("Title"))
                                                                   grid.Add(label, 0, 0)
                                                                   Return New Microsoft.Maui.Controls.ViewCell With {.View = grid}
                                                                 End Function),
        .SeparatorVisibility = Microsoft.Maui.Controls.SeparatorVisibility.None
    }
    Title = "Pages"
    Padding = New Microsoft.Maui.Thickness(0, 5, 0, 0)

    Dim stack As New Microsoft.Maui.Controls.StackLayout
    stack.Children.Add(ListView)

    Content = stack
  End Sub


End Class