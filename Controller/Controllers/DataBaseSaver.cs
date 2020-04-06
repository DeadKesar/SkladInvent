using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller.Controllers
{
    class DataBaseSaver
    {
        
        public void save<T>(List<T> item) where T:class
        {
            using (var db = new SkladContext())
            {
                db.Set<T>().AddRange(item);
                db.SaveChanges();
            }
        }
        public List<T> Load<T>() where T:class
        {
            using (var db = new SkladContext())
            {
                return db.Set<T>().Where(t => true).ToList<T>();
            }
        }

    }
}
