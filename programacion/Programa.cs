using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace programacion
{
    public class Programa : jefe_departamento
    {
        public int clave_curso
        {
            get => default;
            set
            {
            }
        }

        public string Nombre
        {
            get => default;
            set
            {
            }
        }

        public string Duración
        {
            get => default;
            set
            {
            }
        }

        public int Costo
        {
            get => default;
            set
            {
            }
        }

        public int aula_asignada
        {
            get => default;
            set
            {
            }
        }

        public void Sancionar_alumnos()
        {
            throw new System.NotImplementedException();
        }

        public void Cancelar_curso()
        {
            throw new System.NotImplementedException();
        }
    }
}