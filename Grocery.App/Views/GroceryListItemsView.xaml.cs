using Grocery.App.ViewModels;

namespace Grocery.App.Views;

public partial class GroceryListItemsView : ContentPage
{
	public GroceryListItemsView(GroceryListItemsViewModel viewModel)
	{
		InitializeComponent();
        BindingContext = viewModel;
    }

	private void SearchCommand(object sender, TextChangedEventArgs e)
	{
		((GroceryListItemsViewModel)BindingContext).SearchProducts(e.NewTextValue);
	}
}