using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.ObjModel
{
    public class SI
    {
        /// <summary>
        /// Айди для базы данных.
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// Название едениц измерения;
        /// </summary>
        public string SIName { get; set; }
        /// <summary>
        /// пустой конструктор для бд.
        /// </summary>
        public SI() { }
        /// <summary>
        /// значение едениц по умолчанию. //Оно вообще надо?
        /// </summary>
        private const string DefaultNAme = "шт."; 
        /// <summary>
        /// инициализация новых едениц измерения
        /// </summary>
        /// <param name="name">единицы измерения</param>
        public SI(string name=DefaultNAme)
        {
            SIName = name;
        }
    }
}
