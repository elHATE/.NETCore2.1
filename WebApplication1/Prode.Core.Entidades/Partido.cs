using System;
using System.Collections.Generic;
using System.Text;

namespace Prode.Core.Entidades
{
    public class Partido
    {
        public Equipo1 EquipoLocal { get; set; }
        public Equipo1 EquipoVisitante { get; set; }
        public int GolesLocal { get; set; }
        public int GolesVisitante { get; set; }
        public DateTime Fecha { get; set; }

        public string InformaResultado()
        {
            var result = string.Empty;

            if (GolesLocal > GolesVisitante)
            {
                result = "Gano Equipo Local" + EquipoLocal.Nombre;
            }
            else if (GolesLocal < GolesVisitante)
            {
                result = "Gano Equipo Visitante" + EquipoVisitante.Nombre;
            }
            else if (GolesLocal == GolesVisitante)
            {
                result = "Resultado del Partido Empate";
            }

            return result;
        }
    }
}
