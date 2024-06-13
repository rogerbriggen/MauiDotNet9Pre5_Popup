using CommunityToolkit.Maui.Views;

namespace MauiDotNet9Pre5_Popup;

public partial class MainPage : ContentPage
{
	

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
        var popup = new SimplePopup();

        this.ShowPopup(popup);
    }
}

