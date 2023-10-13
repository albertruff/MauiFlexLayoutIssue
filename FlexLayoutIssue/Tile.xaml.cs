

namespace FlexLayoutIssue;

public partial class Tile : ContentView
{
    public Tile()
    {
        InitializeComponent();
    }

    private async void Navigate(object sender, EventArgs e)
    {
        Console.WriteLine("Navigated");
    }
}