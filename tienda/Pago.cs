using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tienda
{
    public class Pago
    {
        public int id
        {
            get => default;
            set
            {
            }
        }

        public int fecha_pago
        {
            get => default;
            set
            {
            }
        }

        public int pago
        {
            get => default;
            set
            {
            }
        }

        public int cuenta_bancaria
        {
            get => default;
            set
            {
            }
        }

        public Envio Envio
        {
            get => default;
            set
            {
            }
        }

        public void tranferencia()
        {
            throw new System.NotImplementedException();
        }

        public void paypal()
        {
            throw new System.NotImplementedException();
        }

        public void efectivo()
        {
            throw new System.NotImplementedException();
        }
    }
}