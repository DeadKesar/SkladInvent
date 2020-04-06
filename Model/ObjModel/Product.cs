using System;
using System.Collections.Generic;

namespace Model.ObjModel
{
    public class Product
    {
        /// <summary>
        /// ID для БД.
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// Имя продукта.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Код из 1Сю
        /// </summary>
        public string OneCCode {get;set;}

        /// <summary>
        /// Артикул продукта.
        /// </summary>
        public string Article { get; set; }
        /// <summary>
        /// Количество.
        /// </summary>
        public double Quantity { get; set; }
        /// <summary>
        /// Система измерений (шт., кучи, пачки и т.д)
        /// </summary>
        public int? SIID { get; set; }
        public virtual SI SI { get; set; }//уже больше пяти придумал, значит надо их добавлять и выбирать... отдельную модель???
        /// <summary>
        /// Адрес полки где лежит.
        /// </summary>
        public string Address { get; set; }

        //public object Image { get; set; }
        //TODO: присобачить возможность делать фотки и сохранять их вместе с продуктом.

        /// <summary>
        /// Коментарий.
        /// </summary>
        public string Coment { get; set; }
        /// <summary>
        /// пустой конструктор для БД.
        /// </summary>
        public Product() { }


        /// <summary>
        /// Проинициализировать объект продукта.
        /// </summary>
        /// <param name="name">Имя</param>
        /// <param name="oneCCode">Сод из 1С</param>
        /// <param name="articl">Артикул</param>
        /// <param name="quant">Количество</param>
        /// <param name="si">Еденицы измерения</param>
        /// <param name="address">Адрес полки</param>
        public Product(string name,string oneCCode="00000",string articl = "0.000.00", double quant = 0 , SI si = default, string address = "Неизвестно",string coment = "No coments!")
        {
            #region проверка аргументов
            //нужны ли проверки для аргументов у которых есть значения по умолчанию, по крайней мере проверки на налл?
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException("имя не должны быть пустым", nameof(name));
            }

            if (string.IsNullOrWhiteSpace(oneCCode))
            {
                OneCCode = "Неизвестно";
            }

            if (string.IsNullOrWhiteSpace(articl))
            {
                Article = "Неизвестно";
            }

            if (quant<0)
            {
                throw new ArgumentException("значение количества не может быть отрицательным", nameof(quant));
            }

            if (string.IsNullOrWhiteSpace(address))
            {
                Address = "Неизвестно";
            }
            if (string.IsNullOrWhiteSpace(Coment))
            {
                Coment = "No coments!!";
            }
            #endregion
            Name = name;
            OneCCode = oneCCode;
            Article = articl;
            Quantity = quant;
            SI = si;
            Address = address;
            Coment = coment;
        }



    }
}
