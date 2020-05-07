using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


namespace Produtos.Entities
{
    class ImportadProduct : Product
    {

        public double CustormsFree { get; set; }

        public ImportadProduct()
        {

        }

        public ImportadProduct(double custormsFree, string name, double price, char priceTag)
            : base (name, price, priceTag)
        {
            CustormsFree = custormsFree;
        }

        public double TotalPrice()
        {
            return Price + CustormsFree;
        }

        public override string Compra()
        {
            return "Nome do produto: " + Name
                + " Valor total: " + TotalPrice().ToString("F2", CultureInfo.InvariantCulture)
                + " Taxa de importação: " + CustormsFree.ToString("F2", CultureInfo.InvariantCulture);

        }

    }
}
