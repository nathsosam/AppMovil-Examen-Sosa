﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp_Examen_SosaGeraldyne.Models
{
    internal class Grupo
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Caracteristica { get; set; }
        public List<Animal> Animales { get; set; }
    }
}
