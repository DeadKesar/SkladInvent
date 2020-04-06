using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.ObjModel;


namespace Controller.Controllers
{
    public delegate void Click(object sender, System.Windows.RoutedEventArgs e);
    public class ProductController : BaseControler
    {
        private Product product;
        public List<Product> Products { get; private set; }
        public void Add(Product prod)
        {
            Products.Add(prod);
        }
        public void Add(string name, string oneCCode = "00000", string articl = "0.000.00", 
                        double quant = 0, string si = "шт.", string address = "Неизвестно",string coment = "No coments!")
        {
            var ssi = Load<SI>().FirstOrDefault<SI>(s => s.SIName == si);
            if (ssi == null)
            {
                ssi = new SI(si);
                var temp = Load<SI>();
                temp.Add(ssi);
                Save<SI>(temp);
            }
            var product = new Product(name, oneCCode, articl, quant, ssi, address,coment);
            Products.Add(product);
            Save<Product>(Products);
        }





    }
}
