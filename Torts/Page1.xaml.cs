using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Torts
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page1 : CarouselPage
    {
        private bool _isNavigating;
        private int selectedIndex;
        public Page1()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();
            BindingContext = new TortViewModel();
            CurrentPageChanged += OnCurrentPageChanged;
        }
        private void OnCurrentPageChanged(object sender, EventArgs e)
        {
            if (_isNavigating)
                return;

            // Запоминаем текущую страницу
            var currentPage = CurrentPage;

            // Запрещаем переход, если это не первая страница
            if (usernameEntry.Text != null && passwordEntry.Text != null)
            {
                if (usernameEntry.Text == "ects" && passwordEntry.Text == "ects2024")
                {
                }
                else
                {
                    ShowErrorMessage("Логин - ects, пароль - ects2024.");
                    _isNavigating = true;
                    CurrentPage = Children[0]; // Возвращаем на первую страницу
                    _isNavigating = false;
                }
            }
            else
            {
                ShowErrorMessage("Логин и пароль не должны быть пустыми.");
                _isNavigating = true;
                CurrentPage = Children[0]; // Возвращаем на первую страницу
                _isNavigating = false;
            }
        }

        async void ShowErrorMessage(string message)
        {
            await Application.Current.MainPage.DisplayAlert("Ошибка", message, "OK");
        }
        private async void OnInfoTortClicked(object sender, EventArgs e)
        {
            var selectedItem = (Tort)carouselView.CurrentItem;
            await Navigation.PushAsync(new Page2(selectedItem));
        }

        private async void OnCalculateCostClicked(object sender, EventArgs e)
        {
            var selectedItem = (Tort)carouselView.CurrentItem;
           
                await Navigation.PushAsync(new Page4(selectedItem));
          
        }
    }
}