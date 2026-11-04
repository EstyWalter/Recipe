using RecipeSystem;

namespace RecipeAppsMAUI;

public partial class Login : ContentPage
{
	public Login()
	{
		InitializeComponent();
        Loginbtn.Clicked += Loginbtn_Clicked;
	}

    private void Cancelbtn_Clicked(object sender, EventArgs e)
    {
        Application.Current.Quit();
    }

    private async void Loginbtn_Clicked(object sender, EventArgs e)
    {
        try
        {
            Messagelbl.Text = "";
            dbManager.SetConnectionString(App.ConnStringSetting, true, UserNametxt.Text, Passwordtxt.Text);
            App.LoggedIn = true;
            await Navigation.PopModalAsync();
        }
        catch (Exception ex)
        {
            Messagelbl.Text = ex.Message;
        }
    }
}