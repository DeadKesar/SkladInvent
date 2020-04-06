using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller.Controllers
{
    public class BaseControler
    {
        private readonly DataBaseSaver saver = new DataBaseSaver();
        public void Save<T>(List<T> item) where T: class
        {
            saver.save<T>(item);
        }
        public List<T> Load<T>() where T:class
        {
            return saver.Load<T>();
        }

    }
}
