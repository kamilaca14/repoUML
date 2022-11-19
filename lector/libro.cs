using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lector
{
    public class libro
    {
        public string Titulo_del_libro
        {
            get => default;
            set
            {
            }
        }

        public string Tipo_de_libro
        {
            get => default;
            set
            {
            }
        }

        public string Autor
        {
            get => default;
            set
            {
            }
        }

        public string Editorial
        {
            get => default;
            set
            {
            }
        }

        public Bibliotecario Bibliotecario
        {
            get => default(lector.Bibliotecario);
            set
            {
            }
        }

        public void informacion()
        {
            throw new System.NotImplementedException();
        }

        public void aprendizaje()
        {
            throw new System.NotImplementedException();
        }

        public void cultura()
        {
            throw new System.NotImplementedException();
        }

        public void hechos()
        {
            throw new System.NotImplementedException();
        }
    }
}