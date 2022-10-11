using System;
using System.Collections.Generic;
using System.Text;

namespace CineCooperativaTresUwu
{
    class Pelicula
    {
        private String titulo { get; set; }
        private DateTime fechaDeEstreno { get; set; }
        private int duracion { get; set; }
        private DateTime fechaDesplazamiento { get; set; }
        private List<Asiento> asientos { get; set; }
    }
}
