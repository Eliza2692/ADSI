using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO
{
    public class HorarioDTO
    {
        public HorarioDTO() { }

        public HorarioDTO(int idHorario, string ciudadOrigen, string ciudadDestino, TimeSpan hora, decimal valor)
        {
            this.IdHorario = idHorario;
            this.CiudadOrigen = ciudadOrigen;
            this.CiudadDestino = ciudadDestino;
            this.Hora = hora;
            this.Valor = valor;
        }

        int idHorario;

        public int IdHorario
        {
            get { return idHorario; }
            set { idHorario = value; }
        }

        string ciudadOrigen;

        public string CiudadOrigen
        {
            get { return ciudadOrigen; }
            set { ciudadOrigen = value; }
        }
        string ciudadDestino;

        public string CiudadDestino
        {
            get { return ciudadDestino; }
            set { ciudadDestino = value; }
        }
        TimeSpan hora;

        public TimeSpan Hora
        {
            get { return hora; }
            set { hora = value; }
        }
        decimal valor;

        public decimal Valor
        {
            get { return valor; }
            set { valor = value; }
        }

        private int idOrigen;

        public int IdOrigen
        {
            get { return idOrigen; }
            set { idOrigen = value; }
        }

        private int idDestino;

        public int IdDestino
        {
            get { return idDestino; }
            set { idDestino = value; }
        }

    }
}
