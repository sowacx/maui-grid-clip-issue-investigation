using Microsoft.Maui.Controls.Shapes;

namespace MauiGridClipInvestigation;

public partial class MainPage : ContentPage
{
    int count = 0;

    public MainPage()
    {
        InitializeComponent();
    }
    
    private void OnCounterClicked(object sender, EventArgs e)
    {
        GridToClip.Clip = GridToClip.Clip is null
            ? new RoundRectangleGeometry(new CornerRadius(6), new Rect(0, 0, GridToClip.Width, GridToClip.Height))
            : null;
        
        Console.WriteLine("!@# OnCounterClicked");
    }

    private void GridToClip_OnUnloaded(object? sender, EventArgs e)
    {
        Console.WriteLine("!@# GridToClip_OnUnloaded fired");
    }

    private void GridToClip_OnLoaded(object? sender, EventArgs e)
    {
        Console.WriteLine("!@# GridToClip_OnLoaded fired");
    }

}