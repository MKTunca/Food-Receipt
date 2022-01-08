using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace AbstractExample
{
    class Program
    {
        static void Main(string[] args)
        {
            FoodMenager foodMenager = new FoodMenager();
            var burger = new Burger
            {
                Name = "Burger",
                Price = 20,
                Kind="Meat burger",
                Portion="1.5",
                ShopName="MCDonalds",
                Location="Esenyurt"
            };
            var pizza = new Pizza
            {
                Name = "Pizza",
                Price = 40,
                Kind = "Mix",
                Portion = "Middle",
                ShopName = "Dominos",
                Location = "Esenyurt"
            };
            var kebap = new Kebap
            {
                Name = "Kebap",
                Price = 30,
                Kind = "Adana",
                Portion = "1",
                ShopName = "Kebap House",
                Location = "Esenyurt"
            };
            int sum = burger.Price + pizza.Price + kebap.Price;
            string sum1 = Convert.ToString(sum);
            foodMenager.Show(burger);
            foodMenager.Show(pizza);
            foodMenager.Show(kebap);
            Console.WriteLine(sum1 + "TL");
            Console.ReadLine();
        }
    }
   interface IFood
    {
        string Name { get; set; }
        int Price { get; set; }
        string Kind { get; set; }
        string Portion { get; set; }
        string ShopName { get; set; }
        string Location { get; set; }
    }
    class Burger : IFood
    {
        public int Price { get ; set ; }
        public string Kind { get ; set; }
        public string Portion { get; set ; }
        public string ShopName { get ; set ; }
        public string Location { get ; set ; }
        public string Name { get ; set; }
    }
    class Pizza : IFood
    {
        public int Price { get; set; }
        public string Kind { get; set; }
        public string Portion { get; set; }
        public string ShopName { get; set; }
        public string Location { get; set; }
        public string Name { get; set; }
    }
    class Kebap : IFood
    {
        public int Price { get; set; }
        public string Kind { get; set; }
        public string Portion { get; set; }
        public string ShopName { get; set; }
        public string Location { get; set; }
        public string Name { get; set; }
    }
    class FoodMenager
    {
        
        public void Show(IFood food)
        {
            Console.WriteLine(food.Name);
            string price = Convert.ToString(food.Price);
            Console.WriteLine(price + "TL");
            Console.WriteLine(food.Kind);
            Console.WriteLine(food.Portion);
            Console.WriteLine(food.ShopName);
            Console.WriteLine(food.Location);
        }
    }

}
