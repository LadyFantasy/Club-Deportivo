using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Club_com_B_grupo3.Datos
{
    public abstract class Persona
    {
        private string nombre, apellido, direccion, mail, telefono;
        private int dni;
        private bool apto;

        public Persona(string nombre,
                       string apellido,
                       string direccion,
                       string mail,
                       string telefono,
                       int dni,
                       bool apto)
        {
            Nombre = nombre;
            Apellido = apellido;
            Direccion = direccion;
            Mail = mail;
            Telefono = telefono;
            Dni = dni;
            Apto = apto;
        }

        public override string ToString()
        {
            return this.apellido + ", " + this.nombre;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Mail { get => mail; set => mail = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public int Dni { get => dni; set => dni = value; }
        public bool Apto { get => apto; set => apto = value; }
    }
}