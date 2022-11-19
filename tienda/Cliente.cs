using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tienda
{
    public class Cliente : persona
    {
        public int Id
        {
            get => default;
            set
            {
            }
        }

        public string direccion
        {
            get => default;
            set
            {
            }
        }

        public int telefono
        {
            get => default;
            set
            {
            }
        }

        public string correo
        {
            get => default;
            set
            {
            }
        }

        public void pedir()
        {
            throw new System.NotImplementedException();
        }

        public void elegir_producto()
        {
            throw new System.NotImplementedException();
        }

        public void num_productos()
        {
            throw new System.NotImplementedException();
        }

        public void llamar()
        {
            throw new System.NotImplementedException();
        }
    }
}