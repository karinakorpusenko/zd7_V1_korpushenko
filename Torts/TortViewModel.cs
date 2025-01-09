using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Torts
{
   public class TortViewModel
    {
        public ObservableCollection<Tort> Torts { get; set; }

        public TortViewModel()
        {
           Torts = new ObservableCollection<Tort>
        {
            new Tort{ Name = "Торт Птичье молоко", ImageUrl = "tort.png", Category = "Десерт", Cost = "1500", Unit = "г", Fats = "22", Proteins = "5", Carbohydrates = "37", Vitamins = "A, B, C", Supplier = "Поставщик A", Recipe = "Рецепт птичьего молока", Quantity = "1",Ves=1,Level="Отсутсвует" },
            new Tort { Name = "Свадебный торт 3х-ярусный", ImageUrl = "cakechel.png", Category = "Десерт", Cost = "4000", Unit = "г", Fats = "45", Proteins = "8", Carbohydrates = "88", Vitamins = "B, C", Supplier = "Поставщик B", Recipe = "Рецепт свадебного торта", Quantity = "1",Ves=1,Level="Отсутсвует" },
            new Tort { Name = "Фруктовый торт", ImageUrl = "tortcrem.jpg", Category = "Десерт", Cost = "2000", Unit = "г", Fats = "15", Proteins = "3", Carbohydrates = "50", Vitamins = "A, C, D", Supplier = "Поставщик C", Recipe = "Рецепт фруктового торта", Quantity = "1",Ves=1,Level="Отсутсвует" },
             new Tort { Name = "Шоколадный торт", ImageUrl = "tortnad.jpg", Category = "Десерт", Cost = "2000", Unit = "г", Fats = "10", Proteins = "2", Carbohydrates = "50", Vitamins = "A, C", Supplier = "Поставщик D", Recipe = "Рецепт шоколадного торта", Quantity = "1",Ves=1,Level="Отсутсвует" }
        };
        }
    }
}
