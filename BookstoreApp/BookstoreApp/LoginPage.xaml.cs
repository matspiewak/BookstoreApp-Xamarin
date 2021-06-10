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
        void SignInProcedure(object sender, EventArgs e)
        {
            UserLogin user = new UserLogin(Entry_Username.Text, Entry_Password.Text);
            if (user.CheckInfo())
            {

                DisplayAlert("Login", "Login Success", "Ok");
            }
            else
            {
                DisplayAlert("Login", "Login Not Correct", "Ok");
            }
        }
    }
}