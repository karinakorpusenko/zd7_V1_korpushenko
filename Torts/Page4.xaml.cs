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
	public partial class Page4 : ContentPage
    {
        Tort selectedTort;
        public Page4 (Tort selectedTort)
		{
			InitializeComponent ();
            NavigationPage.SetHasNavigationBar(this, false);
            this.selectedTort = selectedTort;
            double cakePrice = double.Parse(selectedTort.Cost);
            double ves = selectedTort.Ves;
            
            double totalCost=0;
            if (selectedTort.Level == "Сложная мастика с фигурами людей") totalCost = cakePrice * ves * (1 + 0.40);
            else if (selectedTort.Level == "Дополнительное украшение с помощью крема") totalCost = cakePrice * ves * (1 + 0.20);
            else if (selectedTort.Level == "Наличие надписи") totalCost = cakePrice * ves*(1+ 0.10);
            else  totalCost = cakePrice * ves;
            

            Source.Source = selectedTort.ImageUrl;
            Name.Text = $"Название торта: {selectedTort.Name}";
            Category.Text = $"Категория: {selectedTort.Category}";
            Cost.Text = $"Цена на 1 кг без доп.услуг: {selectedTort.Cost}";
            FinalCost.Text = $"Итоговая цена: {totalCost}";
            Ves.Text = $"Вес торта (кг): {selectedTort.Ves}";
            Level.Text = $"Доп. услуга: {selectedTort.Level}";
        }
        private async void Back(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page2(selectedTort));
        }
        private async void OnCalculateCostClicked(object sender, EventArgs e)
        {
            await Navigation.PopToRootAsync();
            selectedTort.Ves = 1;
            selectedTort.Level = "Отсутсвует";
        }
    }
}