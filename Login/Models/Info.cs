using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Login.Models
{
    public class Info
    {
        [PrimaryKey, AutoIncrement]
        public int id { get; set; }

        [MaxLength(100)]
        public string nombre { get; set; }

        [MaxLength(100)]
        public string apellidos { get; set; }
        public string edad { get; set; }

        [MaxLength(300)]
        public string correo { get; set; }
        public string direccion { get; set; }
    }
}
