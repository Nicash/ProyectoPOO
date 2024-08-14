﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Persona
    {

        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int DNI { get; set; }

        public Persona(string nombre, string apellido, int dni)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.DNI = dni;
        }


    }
}
