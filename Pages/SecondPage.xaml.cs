using CodeTest.ViewModels;

namespace CodeTest.Pages;

public partial class SecondPage : ContentPage
{
	public SecondPage(SecondPageViewModel vm)
	{
		InitializeComponent();

		this.BindingContext = vm;
	}
}