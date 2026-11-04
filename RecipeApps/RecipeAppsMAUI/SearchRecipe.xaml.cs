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
        DataTable dtRecipe = Recipe.GetRecipe("@List", 1);
        RecipeLst.ItemsSource = dtRecipe.Rows;
    }

    private void SearchRecipebtn_Clicked(object sender, EventArgs e)
    {
		SearchRecipes();
    }


}