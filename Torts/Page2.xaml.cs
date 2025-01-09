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
	public partial class Page2 : ContentPage
	{
        Tort selectedTort;
        
        public Page2(Tort selectedTort)
        {
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();
            this.selectedTort = selectedTort;                                       
           Imagee.Source = selectedTort.ImageUrl;
            Name.Text = $"Название торта: {selectedTort.Name}";
            Category.Text = $"Категория: {selectedTort.Category}";
            Cost.Text = $"Цена на 1 кг: {selectedTort.Cost}";
            Unit.Text = $"Жиры: {selectedTort.Fats}";
            Fats.Text = $"Белки: {selectedTort.Proteins}";
            Proteins.Text = $"Углеводы: {selectedTort.Carbohydrates}";
            Carbohydrates.Text = $"Единицы измерения:  {selectedTort.Unit}";
            Vitamins.Text = $"Витамины:  {selectedTort.Vitamins}";
            Supplier.Text = $"Поставщик: {selectedTort.Supplier}";
            Recipe.Text = $"Рецепт: {selectedTort.Recipe}";
            Quantity.Text = $"Количество:{selectedTort.Quantity}";
        }

        private async void Back(object sender, EventArgs e)
        {
            await Navigation.PopToRootAsync();
        }

        async void ShowErrorMessage(string message)
        {
            await Application.Current.MainPage.DisplayAlert("Ошибка", message, "OK");
        }

        private async void OnCalculateCostClicked(object sender, EventArgs e)
        {
            
          
            if (Ves.Text != null&&ComplexityPicker.SelectedItem!=null)
            {
                if (Convert.ToDouble(Ves.Text) >=0.5 && Convert.ToDouble(Ves.Text) <=10)
                {
                    selectedTort.Ves= Convert.ToDouble(Ves.Text);
                   
                    switch (ComplexityPicker.SelectedItem.ToString())
                    {
                        case "Сложная мастика с фигурами людей":
                            selectedTort.Level = "Сложная мастика с фигурами людей";
                            break;
                        case "Дополнительное украшение с помощью крема":
                            selectedTort.Level = "Дополнительное украшение с помощью крема";
                            break;
                        case "Наличие надписи":
                            selectedTort.Level = "Наличие надписи";
                            break;
                        default:
                            selectedTort.Level = "Отсутсвует";
                            break;
                    }
                    await Navigation.PushAsync(new Page4(selectedTort));
           
                 
                }
                else
                    ShowErrorMessage("Вес должен быть от 0,5 кг до 10 кг");
            }
            else
                ShowErrorMessage("Поля не должны быть пустыми");
        }
    }
}