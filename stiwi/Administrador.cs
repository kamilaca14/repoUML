using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace stiwi
{
    public class Administrador : usuario
    {
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

        public string contraseña
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

        public string dirección
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

        public Pago Pago
        {
            get => default;
            set
            {
            }
        }

        public void Vigilar()
        {
            throw new System.NotImplementedException();
        }

        public void Mantener_un_orden()
        {
            throw new System.NotImplementedException();
        }
    }
}