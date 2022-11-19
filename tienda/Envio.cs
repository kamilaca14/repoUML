using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tienda
{
    public class Envio
    {
        public int id
        {
            get => default;
            set
            {
            }
        }

        public string dirección_facturación
        {
            get => default;
            set
            {
            }
        }

        public string finalizado
        {
            get => default;
            set
            {
            }
        }

        public string fecha_envio
        {
            get => default;
            set
            {
            }
        }

        public string compañia
        {
            get => default;
            set
            {
            }
        }

        public void envio_adomicilio()
        {
            throw new System.NotImplementedException();
        }

        public void envio_apunto_de_entrega()
        {
            throw new System.NotImplementedException();
        }

        public void envio_urgente()
        {
            throw new System.NotImplementedException();
        }

        public void envio_internacional()
        {
            throw new System.NotImplementedException();
        }
    }
}