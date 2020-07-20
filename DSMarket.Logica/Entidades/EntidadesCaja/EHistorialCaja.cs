﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSMarket.Logica.Entidades.EntidadesCaja
{
    public class EHistorialCaja
    {
        public decimal? IdHistorialCaja { get; set; }

        public System.Nullable<decimal> IdCaja { get; set; }

        public System.Nullable<decimal> Monto { get; set; }

        public string Concepto { get; set; }

        public System.Nullable<System.DateTime> Fecha0 { get; set; }

        public string Fecha { get; set; }

        public System.Nullable<decimal> IdUsuario { get; set; }

        public string CreadoPor { get; set; }

        public System.Nullable<decimal> NumeroReferencia { get; set; }

        public System.Nullable<decimal> IdTipoPago { get; set; }

        public string TipoPago { get; set; }
        public System.Nullable<decimal> Total { get; set; }
    }
}
