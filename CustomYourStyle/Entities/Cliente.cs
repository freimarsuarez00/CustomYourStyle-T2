﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomYourStyle.Entities
{
    public class Cliente : Persona
    {
        public int IdCliente { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string Direccion { get; set; }
    }
}
