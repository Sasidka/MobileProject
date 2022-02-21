using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ThirdMobProject
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProfilePage : ContentPage
    {
        public string login, password, gender;

        private void BackBtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new UserPage());
        }

        public ProfilePage(string getLogin, string getPassword, string getGender)
        {
            InitializeComponent();
            login = getLogin;
            password = getPassword;
            gender = getGender;
            LoginLbl.Text = login;
            passwordLbl.Text = password;
            genderLbl.Text = gender;

        }
    }
}