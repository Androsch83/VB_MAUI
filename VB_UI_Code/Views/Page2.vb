Public Class Page2
  Inherits Microsoft.Maui.Controls.ContentPage

  Sub New()
    BackgroundColor = Microsoft.Maui.Graphics.Colors.Gray

    Dim grid = New Microsoft.Maui.Controls.Grid With {
    .RowDefinitions = New Microsoft.Maui.Controls.RowDefinitionCollection From
   {
       New Microsoft.Maui.Controls.RowDefinition With {.Height = 80}
    }
}

    grid.Add(New Microsoft.Maui.Controls.Label With {
                        .Text = "Page2",
                        .FontSize = 36,
                        .FontAttributes = Microsoft.Maui.Controls.FontAttributes.Bold,
                        .HorizontalTextAlignment = Microsoft.Maui.TextAlignment.Center
                      }, 0, 0)

    Content = grid
  End Sub
End Class
