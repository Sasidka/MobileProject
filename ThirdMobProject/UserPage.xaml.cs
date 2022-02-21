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
    public partial class UserPage : ContentPage
    {
        public UserPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

        }

        private void SignInBtn_Clicked(object sender, EventArgs e)
        {
            
            var login = "Said445";
            var password = "Fur";
            if ( LogEntry.Text == login && PassEntry.Text == password && GenderPicker.SelectedItem.ToString() == "Мужской")
            {
                //навигация к странице ProfilePage
                Navigation.PushAsync(new ProfilePage(login, password, GenderPicker.SelectedItem.ToString()));
            }
            else
            {
                //Всплывающее уведомление
                DisplayAlert("Ошибка", "Введен неправильный логин или пароль", "Ок");
            }
        }
    }
}