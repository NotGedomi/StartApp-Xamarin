using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Start.Modelos ///Representación de la tabla y propiedades
{
    public class Actividad
    {
        [PrimaryKey,AutoIncrement]
        public int IdActividad { get; set; }

        [MaxLength(50)]
        public string Descripcion { get; set; }

        [MaxLength(50)]
        public string Fecha { get; set; }

        [MaxLength (50)]
        public string Hora { get; set; }
    }
}
