using System;
using System.Collections.Generic;
using System.Text;

namespace Torts
{
    public class Tort
    {
        public string Name { get; set; } //название
        public string ImageUrl { get; set; }
        public string Category { get; set; } //категория
        public string Cost { get; set; }//стоимость
        public string Unit { get; set; }//ед изм
        public string Fats { get; set; }//жиры
        public string Proteins { get; set; }//белки
        public string Carbohydrates { get; set; }//углеводы
        public string Vitamins { get; set; }//витамины
        public string Supplier { get; set; }//поставщик
        public string Recipe { get; set; }//рецепт
        public string Quantity { get; set; }//количество

        public double Ves {  get; set; }
        public string Level {  get; set; }
    }
}
