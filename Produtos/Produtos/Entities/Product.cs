using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Produtos.Entities
{
    class Product
    {

        public string Name { get; set; }
        public double Price { get; set; }
        public char PriceTag { get; set; }

        public Product()
        {

        }

        public Product(string name, double price, char priceTag)
        {
            Name = name;
            Price = price;
            PriceTag = priceTag;

        }

        //public virtual double TotalPrice()
        //{
        //    return Price;
        //}

        public virtual string Compra()
        {
            return "Nome do produto: " + Name
                + " Valor total: " + Price.ToString("F2", CultureInfo.InvariantCulture);

        }
    }
}
