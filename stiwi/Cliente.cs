using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace stiwi
{
    public class Cliente : usuario
    {
        public string Ci
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

        public string Apellido
        {
            get => default;
            set
            {
            }
        }

        public string Dirección
        {
            get => default;
            set
            {
            }
        }

        public habitación habitación
        {
            get => default;
            set
            {
            }
        }

        public void verificar()
        {
            throw new System.NotImplementedException();
        }

        public void elegir_habitación()
        {
            throw new System.NotImplementedException();
        }
    }
}