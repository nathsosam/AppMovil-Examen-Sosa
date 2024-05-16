using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp_Examen_SosaGeraldyne.Models
{
    internal class Animal
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int GrupoId { get; set; }
        public Grupo Grupo { get; set; }
    }
}
