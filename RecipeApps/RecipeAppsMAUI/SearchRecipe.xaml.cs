using RecipeSystem;
using System.Data;

namespace RecipeAppsMAUI;

public partial class SearchRecipe : ContentPage
{
	public SearchRecipe()
	{
		InitializeComponent();
	}

    private void SearchRecipes()
    {
        bizRecipe rec = new();
        var lst = rec.GetList();

        RecipeLst.ItemsSource = lst;
    }

    private void SearchRecipebtn_Clicked(object sender, EventArgs e)
    {
		SearchRecipes();
    }


}