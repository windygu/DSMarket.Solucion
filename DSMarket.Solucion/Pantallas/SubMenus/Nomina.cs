﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSMarket.Solucion.Pantallas.SubMenus
{
    public partial class Nomina : Form
    {
        public Nomina()
        {
            InitializeComponent();
        }

        private void PCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Nomina_Load(object sender, EventArgs e)
        {
            lbTitulo.Text = "MODULO DE EMPRESA";
            lbTitulo.ForeColor = Color.White;
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            DSMarket.Solucion.Pantallas.Pantallas.Empresa.ClientesConsulta Clientes = new Pantallas.Empresa.ClientesConsulta();
            Clientes.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DSMarket.Solucion.Pantallas.Pantallas.Empresa.NominaConsulta Nomina = new Pantallas.Empresa.NominaConsulta();
            Nomina.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DSMarket.Solucion.Pantallas.Pantallas.Empresa.DepartamentosConsulta Departamentos = new Pantallas.Empresa.DepartamentosConsulta();
            Departamentos.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DSMarket.Solucion.Pantallas.Pantallas.Empresa.CargosConsulta Cargos = new Pantallas.Empresa.CargosConsulta();
            Cargos.ShowDialog();
        }
    }
}
