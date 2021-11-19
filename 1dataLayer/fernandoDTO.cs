﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1dataLayer
{
    class fernandoDTO
    {
        public class tutor
        {
            public int id_tutor { get; }
            public string Nombre { get; set; }
            public string Apellido_paterno { get; set; }
            public string Apellido_materno { get; set; }
            public string colonia_tutor { get; set; }
            public string calle_tutor { get; set; }
            public string numero_tutor { get; set; }
            public string ocupacion_tutor { get; set; }
            public string colonia_trabajo_tutor { get; set; }
            public string calle_trabajo_tutor { get; set; }
            public string numero_trabajo_tutor { get; set; }
        }

        public class tutor_alumno
        {
            public int id_alumno { get; }
            public int id_tutor { get; }
        }

        public class telefono_tutor
        {
            public int id_tutor { get; }
            public int id_telefono { get; }
            public int telefono { get; set; }
        }

        public class identidicadores_telefonos
        {
            public int id_telefono { get; }
            public string tipo_telefono { get; set; }
        }
    }
}
