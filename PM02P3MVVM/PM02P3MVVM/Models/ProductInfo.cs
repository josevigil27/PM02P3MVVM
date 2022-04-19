using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace PM02P3MVVM.Models
{
    public class ProductInfo
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Edad { get; set; }
        public string Direccion { get; set; }
        public string Puesto { get; set; }


    }
}
