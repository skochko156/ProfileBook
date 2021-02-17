using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ProfileBook
{
    public partial class MainPage : ContentPage
    {
        

        public MainPage()
        {
            InitializeComponent();
            StackLayout stackLayout = new StackLayout();

            UserLogin = new Entry { Placeholder = "Login" };
            UserLogin.TextChanged += UserLogin_TextChanged;

         

            UserPassword = new Entry
            {
                Placeholder = "Password",
                IsPassword = true
            };
            textLabel = new Label { FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)) };

            stackLayout.Children.Add(UserLogin);
            stackLayout.Children.Add(UserPassword);
            stackLayout.Children.Add(textLabel);
            this.Content = stackLayout;

        }
        

        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            (sender as Button).Text = "Click me again!";
        }

        

        void UserLogin_TextChanged(System.Object sender, Xamarin.Forms.TextChangedEventArgs e)
        {
            textLabel.Text = UserLogin.Text;
        }
    }
}
