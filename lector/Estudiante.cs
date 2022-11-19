using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lector
{
    public class Estudiante : lector
    {
        public string Edad
        {
            get => default;
            set
            {
            }
        }

        public string plantel
        {
            get => default;
            set
            {
            }
        }

        public string curso
        {
            get => default;
            set
            {
            }
        }

        public string codigo_estudiante
        {
            get => default;
            set
            {
            }
        }

        public libro libro
        {
            get => default(lector.libro);
            set
            {
            }
        }

        public void leer()
        {
            throw new System.NotImplementedException();
        }

        public void Adeudo()
        {
            throw new System.NotImplementedException();
        }

        public void elegir_libro()
        {
            throw new System.NotImplementedException();
        }

        public void Num_libros()
        {
            throw new System.NotImplementedException();
        }
    }
}