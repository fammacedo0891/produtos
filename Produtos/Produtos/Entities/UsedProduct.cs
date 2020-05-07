using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Produtos.Entities
{
    class UsedProduct : Product
    {

        public DateTime ManufactureDate { get; set; }

        public UsedProduct()
        {
        }

        public UsedProduct(DateTime manufactureDate, string name, double price, char priceTag)
            : base (name, price, priceTag)
        {
            ManufactureDate = manufactureDate;
        }

        
        public override string Compra()
        {
            return "Nome do produto: " + Name
                + " Valor total: " + Price.ToString("F2", CultureInfo.InvariantCulture)
                + " Data de fabricação: " + ManufactureDate.ToString("dd/MM/yyyy");

        }

    }
}
