using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2
{
    class Persona
    {
        private string rut;
        private string nombre;
        private string apellido_pa;
        private string apellido_ma;
        private string edad;
        private string correo;
        private string fono;
        public Persona()
        {

        }
       

        public string Rut { get => rut; set => rut = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido_pa { get => apellido_pa; set => apellido_pa = value; }
        public string Apellido_ma { get => apellido_ma; set => apellido_ma = value; }
        public string Edad { get => edad; set => edad = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Fono { get => fono; set => fono = value; }
        public string GetRut()
        {
            return rut;
        }
        public void SetRut(string nuevoRut)
        {
            rut = nuevoRut;
        }
        
    }
}
