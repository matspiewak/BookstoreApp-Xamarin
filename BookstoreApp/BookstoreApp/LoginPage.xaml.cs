using BookstoreApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BookstoreApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            Init();
        }
        void Init()
        {
            BackgroundImageSource = "LoginBackground.png";
        }
        async void SignInProcedure(object sender, EventArgs e)
        {
            UserLogin user = new UserLogin(Entry_Username.Text, Entry_Password.Text);
            if (user.CheckInfo())
            {
                await Navigation.PushAsync(new MainPage());
            }
            else
            {
                DisplayAlert("Login", "Login Not Correct", "Ok");
            }
        }
    }
}