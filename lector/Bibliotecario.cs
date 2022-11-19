using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lector
{
    public class Bibliotecario : lector
    {
        public string id_del_personal
        {
            get => default;
            set
            {
            }
        }

        public string cedula
        {
            get => default;
            set
            {
            }
        }

        public int Biblioteca
        {
            get => default;
            set
            {
            }
        }

        public int h_laborales
        {
            get => default;
            set
            {
            }
        }

        public Pedido Pedido
        {
            get => default(lector.Pedido);
            set
            {
            }
        }

        public void informar()
        {
            throw new System.NotImplementedException();
        }

        public void entregar()
        {
            throw new System.NotImplementedException();
        }

        public void vigilar()
        {
            throw new System.NotImplementedException();
        }

        public void p_devolucion()
        {
            throw new System.NotImplementedException();
        }
    }
}