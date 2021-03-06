﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSMarket.Logica.Entidades.EntidadesServicio
{
    public class EFacturacionClientes
    {
		public System.Nullable<decimal> IdFactura {get;set;}

		public System.Nullable<decimal> NumeroConector {get;set;}

		public System.Nullable<int> IdEstatusFacturacion {get;set;}

		public System.Nullable<decimal> IdComprobante {get;set;}

		public string Nombre {get;set;}

		public string Telefono {get;set;}

		public string Email {get;set;}

		public System.Nullable<decimal> IdTipoIdentificacion {get;set;}

		public string NumeroIdentificacion {get;set;}

		public string Direccion {get;set;}

		public string Comentario {get;set;}

		public System.Nullable<decimal> IdTipoVenta {get;set;}

		public System.Nullable<decimal> IdCantidadDias {get;set;}

		public System.Nullable<decimal> IdUsuario {get;set;}

		public System.Nullable<System.DateTime> FechaFacturacion {get;set;}

		public System.Nullable<bool> AplicaGarantia {get;set;}

		public System.Nullable<int> DiasGarantia {get;set;}

		public System.Nullable<int> IdTipoIngreso {get;set;}

		public System.Nullable<decimal> IdTipoAnulaicon {get;set;}

		public System.Nullable<int> TipoTiempoGarantia {get;set;}
	}
}
