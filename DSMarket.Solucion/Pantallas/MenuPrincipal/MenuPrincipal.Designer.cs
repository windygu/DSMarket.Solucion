﻿namespace DSMarket.Solucion.Pantallas.MenuPrincipal
{
    partial class MenuPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            this.PanelTop = new System.Windows.Forms.Panel();
            this.PanelMenu = new System.Windows.Forms.Panel();
            this.PanelCuerpo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.Curva = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.CurvaForms = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.lbLogoCorto = new System.Windows.Forms.PictureBox();
            this.PanelOpciones = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnSuplidores = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnNomina = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnClientes = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnCerrarSesion = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSeguridad = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnConfiguracion = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnCaja = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnInventario = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnServicio = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Separador = new Bunifu.Framework.UI.BunifuSeparator();
            this.pbLogolargo = new System.Windows.Forms.PictureBox();
            this.PRestaurar = new System.Windows.Forms.PictureBox();
            this.PMinimizar = new System.Windows.Forms.PictureBox();
            this.PMaximizar = new System.Windows.Forms.PictureBox();
            this.PCerrar = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.EfectoIda = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.PanelTop.SuspendLayout();
            this.PanelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lbLogoCorto)).BeginInit();
            this.PanelOpciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogolargo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelTop
            // 
            this.PanelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.PanelTop.Controls.Add(this.PRestaurar);
            this.PanelTop.Controls.Add(this.label1);
            this.PanelTop.Controls.Add(this.PMinimizar);
            this.PanelTop.Controls.Add(this.PMaximizar);
            this.PanelTop.Controls.Add(this.PCerrar);
            this.PanelTop.Controls.Add(this.pictureBox1);
            this.EfectoIda.SetDecoration(this.PanelTop, BunifuAnimatorNS.DecorationType.None);
            this.PanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTop.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PanelTop.Location = new System.Drawing.Point(0, 0);
            this.PanelTop.Name = "PanelTop";
            this.PanelTop.Size = new System.Drawing.Size(1400, 80);
            this.PanelTop.TabIndex = 0;
            // 
            // PanelMenu
            // 
            this.PanelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.PanelMenu.Controls.Add(this.PanelOpciones);
            this.EfectoIda.SetDecoration(this.PanelMenu, BunifuAnimatorNS.DecorationType.None);
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMenu.Location = new System.Drawing.Point(0, 80);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(300, 820);
            this.PanelMenu.TabIndex = 1;
            // 
            // PanelCuerpo
            // 
            this.EfectoIda.SetDecoration(this.PanelCuerpo, BunifuAnimatorNS.DecorationType.None);
            this.PanelCuerpo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelCuerpo.Location = new System.Drawing.Point(300, 80);
            this.PanelCuerpo.Name = "PanelCuerpo";
            this.PanelCuerpo.Size = new System.Drawing.Size(1100, 820);
            this.PanelCuerpo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.EfectoIda.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(48, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre Empresa";
            // 
            // Curva
            // 
            this.Curva.ElipseRadius = 10;
            this.Curva.TargetControl = this.PanelOpciones;
            // 
            // CurvaForms
            // 
            this.CurvaForms.ElipseRadius = 20;
            this.CurvaForms.TargetControl = this;
            // 
            // lbLogoCorto
            // 
            this.lbLogoCorto.BackColor = System.Drawing.Color.Transparent;
            this.EfectoIda.SetDecoration(this.lbLogoCorto, BunifuAnimatorNS.DecorationType.None);
            this.lbLogoCorto.Image = global::DSMarket.Solucion.Properties.Resources.Iniciales;
            this.lbLogoCorto.Location = new System.Drawing.Point(3, 3);
            this.lbLogoCorto.Name = "lbLogoCorto";
            this.lbLogoCorto.Size = new System.Drawing.Size(60, 44);
            this.lbLogoCorto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lbLogoCorto.TabIndex = 15;
            this.lbLogoCorto.TabStop = false;
            this.lbLogoCorto.Visible = false;
            // 
            // PanelOpciones
            // 
            this.PanelOpciones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.PanelOpciones.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PanelOpciones.BackgroundImage")));
            this.PanelOpciones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelOpciones.Controls.Add(this.lbLogoCorto);
            this.PanelOpciones.Controls.Add(this.btnSuplidores);
            this.PanelOpciones.Controls.Add(this.btnNomina);
            this.PanelOpciones.Controls.Add(this.btnClientes);
            this.PanelOpciones.Controls.Add(this.btnCerrarSesion);
            this.PanelOpciones.Controls.Add(this.btnSeguridad);
            this.PanelOpciones.Controls.Add(this.btnConfiguracion);
            this.PanelOpciones.Controls.Add(this.btnCaja);
            this.PanelOpciones.Controls.Add(this.btnInventario);
            this.PanelOpciones.Controls.Add(this.btnServicio);
            this.PanelOpciones.Controls.Add(this.Separador);
            this.PanelOpciones.Controls.Add(this.pbLogolargo);
            this.EfectoIda.SetDecoration(this.PanelOpciones, BunifuAnimatorNS.DecorationType.None);
            this.PanelOpciones.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.PanelOpciones.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.PanelOpciones.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.PanelOpciones.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.PanelOpciones.Location = new System.Drawing.Point(12, 6);
            this.PanelOpciones.Name = "PanelOpciones";
            this.PanelOpciones.Quality = 10;
            this.PanelOpciones.Size = new System.Drawing.Size(270, 793);
            this.PanelOpciones.TabIndex = 0;
            // 
            // btnSuplidores
            // 
            this.btnSuplidores.Active = false;
            this.btnSuplidores.Activecolor = System.Drawing.Color.Transparent;
            this.btnSuplidores.BackColor = System.Drawing.Color.Transparent;
            this.btnSuplidores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSuplidores.BorderRadius = 0;
            this.btnSuplidores.ButtonText = "      SUPLIDORES";
            this.btnSuplidores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EfectoIda.SetDecoration(this.btnSuplidores, BunifuAnimatorNS.DecorationType.None);
            this.btnSuplidores.DisabledColor = System.Drawing.Color.Gray;
            this.btnSuplidores.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSuplidores.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSuplidores.Iconimage")));
            this.btnSuplidores.Iconimage_right = null;
            this.btnSuplidores.Iconimage_right_Selected = null;
            this.btnSuplidores.Iconimage_Selected = null;
            this.btnSuplidores.IconMarginLeft = 0;
            this.btnSuplidores.IconMarginRight = 0;
            this.btnSuplidores.IconRightVisible = true;
            this.btnSuplidores.IconRightZoom = 0D;
            this.btnSuplidores.IconVisible = true;
            this.btnSuplidores.IconZoom = 90D;
            this.btnSuplidores.IsTab = false;
            this.btnSuplidores.Location = new System.Drawing.Point(9, 343);
            this.btnSuplidores.Name = "btnSuplidores";
            this.btnSuplidores.Normalcolor = System.Drawing.Color.Transparent;
            this.btnSuplidores.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnSuplidores.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSuplidores.selected = false;
            this.btnSuplidores.Size = new System.Drawing.Size(241, 48);
            this.btnSuplidores.TabIndex = 14;
            this.btnSuplidores.Text = "      SUPLIDORES";
            this.btnSuplidores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuplidores.Textcolor = System.Drawing.Color.White;
            this.btnSuplidores.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnNomina
            // 
            this.btnNomina.Active = false;
            this.btnNomina.Activecolor = System.Drawing.Color.Transparent;
            this.btnNomina.BackColor = System.Drawing.Color.Transparent;
            this.btnNomina.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNomina.BorderRadius = 0;
            this.btnNomina.ButtonText = "      NOMINA";
            this.btnNomina.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EfectoIda.SetDecoration(this.btnNomina, BunifuAnimatorNS.DecorationType.None);
            this.btnNomina.DisabledColor = System.Drawing.Color.Gray;
            this.btnNomina.Iconcolor = System.Drawing.Color.Transparent;
            this.btnNomina.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnNomina.Iconimage")));
            this.btnNomina.Iconimage_right = null;
            this.btnNomina.Iconimage_right_Selected = null;
            this.btnNomina.Iconimage_Selected = null;
            this.btnNomina.IconMarginLeft = 0;
            this.btnNomina.IconMarginRight = 0;
            this.btnNomina.IconRightVisible = true;
            this.btnNomina.IconRightZoom = 0D;
            this.btnNomina.IconVisible = true;
            this.btnNomina.IconZoom = 90D;
            this.btnNomina.IsTab = false;
            this.btnNomina.Location = new System.Drawing.Point(9, 285);
            this.btnNomina.Name = "btnNomina";
            this.btnNomina.Normalcolor = System.Drawing.Color.Transparent;
            this.btnNomina.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnNomina.OnHoverTextColor = System.Drawing.Color.White;
            this.btnNomina.selected = false;
            this.btnNomina.Size = new System.Drawing.Size(241, 48);
            this.btnNomina.TabIndex = 13;
            this.btnNomina.Text = "      NOMINA";
            this.btnNomina.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNomina.Textcolor = System.Drawing.Color.White;
            this.btnNomina.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnClientes
            // 
            this.btnClientes.Active = false;
            this.btnClientes.Activecolor = System.Drawing.Color.Transparent;
            this.btnClientes.BackColor = System.Drawing.Color.Transparent;
            this.btnClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClientes.BorderRadius = 0;
            this.btnClientes.ButtonText = "      CLIENTES";
            this.btnClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EfectoIda.SetDecoration(this.btnClientes, BunifuAnimatorNS.DecorationType.None);
            this.btnClientes.DisabledColor = System.Drawing.Color.Gray;
            this.btnClientes.Iconcolor = System.Drawing.Color.Transparent;
            this.btnClientes.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnClientes.Iconimage")));
            this.btnClientes.Iconimage_right = null;
            this.btnClientes.Iconimage_right_Selected = null;
            this.btnClientes.Iconimage_Selected = null;
            this.btnClientes.IconMarginLeft = 0;
            this.btnClientes.IconMarginRight = 0;
            this.btnClientes.IconRightVisible = true;
            this.btnClientes.IconRightZoom = 0D;
            this.btnClientes.IconVisible = true;
            this.btnClientes.IconZoom = 90D;
            this.btnClientes.IsTab = false;
            this.btnClientes.Location = new System.Drawing.Point(9, 231);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Normalcolor = System.Drawing.Color.Transparent;
            this.btnClientes.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnClientes.OnHoverTextColor = System.Drawing.Color.White;
            this.btnClientes.selected = false;
            this.btnClientes.Size = new System.Drawing.Size(241, 48);
            this.btnClientes.TabIndex = 12;
            this.btnClientes.Text = "      CLIENTES";
            this.btnClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.Textcolor = System.Drawing.Color.White;
            this.btnClientes.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Active = false;
            this.btnCerrarSesion.Activecolor = System.Drawing.Color.Transparent;
            this.btnCerrarSesion.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrarSesion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCerrarSesion.BorderRadius = 0;
            this.btnCerrarSesion.ButtonText = "      CERRAR SESION";
            this.btnCerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EfectoIda.SetDecoration(this.btnCerrarSesion, BunifuAnimatorNS.DecorationType.None);
            this.btnCerrarSesion.DisabledColor = System.Drawing.Color.Gray;
            this.btnCerrarSesion.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCerrarSesion.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnCerrarSesion.Iconimage")));
            this.btnCerrarSesion.Iconimage_right = null;
            this.btnCerrarSesion.Iconimage_right_Selected = null;
            this.btnCerrarSesion.Iconimage_Selected = null;
            this.btnCerrarSesion.IconMarginLeft = 0;
            this.btnCerrarSesion.IconMarginRight = 0;
            this.btnCerrarSesion.IconRightVisible = true;
            this.btnCerrarSesion.IconRightZoom = 0D;
            this.btnCerrarSesion.IconVisible = true;
            this.btnCerrarSesion.IconZoom = 90D;
            this.btnCerrarSesion.IsTab = false;
            this.btnCerrarSesion.Location = new System.Drawing.Point(9, 505);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Normalcolor = System.Drawing.Color.Transparent;
            this.btnCerrarSesion.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnCerrarSesion.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCerrarSesion.selected = false;
            this.btnCerrarSesion.Size = new System.Drawing.Size(241, 48);
            this.btnCerrarSesion.TabIndex = 11;
            this.btnCerrarSesion.Text = "      CERRAR SESION";
            this.btnCerrarSesion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrarSesion.Textcolor = System.Drawing.Color.White;
            this.btnCerrarSesion.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnSeguridad
            // 
            this.btnSeguridad.Active = false;
            this.btnSeguridad.Activecolor = System.Drawing.Color.Transparent;
            this.btnSeguridad.BackColor = System.Drawing.Color.Transparent;
            this.btnSeguridad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSeguridad.BorderRadius = 0;
            this.btnSeguridad.ButtonText = "      SEGURIDAD";
            this.btnSeguridad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EfectoIda.SetDecoration(this.btnSeguridad, BunifuAnimatorNS.DecorationType.None);
            this.btnSeguridad.DisabledColor = System.Drawing.Color.Gray;
            this.btnSeguridad.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSeguridad.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSeguridad.Iconimage")));
            this.btnSeguridad.Iconimage_right = null;
            this.btnSeguridad.Iconimage_right_Selected = null;
            this.btnSeguridad.Iconimage_Selected = null;
            this.btnSeguridad.IconMarginLeft = 0;
            this.btnSeguridad.IconMarginRight = 0;
            this.btnSeguridad.IconRightVisible = true;
            this.btnSeguridad.IconRightZoom = 0D;
            this.btnSeguridad.IconVisible = true;
            this.btnSeguridad.IconZoom = 90D;
            this.btnSeguridad.IsTab = false;
            this.btnSeguridad.Location = new System.Drawing.Point(9, 451);
            this.btnSeguridad.Name = "btnSeguridad";
            this.btnSeguridad.Normalcolor = System.Drawing.Color.Transparent;
            this.btnSeguridad.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnSeguridad.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSeguridad.selected = false;
            this.btnSeguridad.Size = new System.Drawing.Size(241, 48);
            this.btnSeguridad.TabIndex = 10;
            this.btnSeguridad.Text = "      SEGURIDAD";
            this.btnSeguridad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSeguridad.Textcolor = System.Drawing.Color.White;
            this.btnSeguridad.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnConfiguracion
            // 
            this.btnConfiguracion.Active = false;
            this.btnConfiguracion.Activecolor = System.Drawing.Color.Transparent;
            this.btnConfiguracion.BackColor = System.Drawing.Color.Transparent;
            this.btnConfiguracion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConfiguracion.BorderRadius = 0;
            this.btnConfiguracion.ButtonText = "      CONFIGURACION";
            this.btnConfiguracion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EfectoIda.SetDecoration(this.btnConfiguracion, BunifuAnimatorNS.DecorationType.None);
            this.btnConfiguracion.DisabledColor = System.Drawing.Color.Gray;
            this.btnConfiguracion.Iconcolor = System.Drawing.Color.Transparent;
            this.btnConfiguracion.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnConfiguracion.Iconimage")));
            this.btnConfiguracion.Iconimage_right = null;
            this.btnConfiguracion.Iconimage_right_Selected = null;
            this.btnConfiguracion.Iconimage_Selected = null;
            this.btnConfiguracion.IconMarginLeft = 0;
            this.btnConfiguracion.IconMarginRight = 0;
            this.btnConfiguracion.IconRightVisible = true;
            this.btnConfiguracion.IconRightZoom = 0D;
            this.btnConfiguracion.IconVisible = true;
            this.btnConfiguracion.IconZoom = 90D;
            this.btnConfiguracion.IsTab = false;
            this.btnConfiguracion.Location = new System.Drawing.Point(9, 397);
            this.btnConfiguracion.Name = "btnConfiguracion";
            this.btnConfiguracion.Normalcolor = System.Drawing.Color.Transparent;
            this.btnConfiguracion.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnConfiguracion.OnHoverTextColor = System.Drawing.Color.White;
            this.btnConfiguracion.selected = false;
            this.btnConfiguracion.Size = new System.Drawing.Size(241, 48);
            this.btnConfiguracion.TabIndex = 9;
            this.btnConfiguracion.Text = "      CONFIGURACION";
            this.btnConfiguracion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfiguracion.Textcolor = System.Drawing.Color.White;
            this.btnConfiguracion.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnCaja
            // 
            this.btnCaja.Active = false;
            this.btnCaja.Activecolor = System.Drawing.Color.Transparent;
            this.btnCaja.BackColor = System.Drawing.Color.Transparent;
            this.btnCaja.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCaja.BorderRadius = 0;
            this.btnCaja.ButtonText = "      CAJA";
            this.btnCaja.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EfectoIda.SetDecoration(this.btnCaja, BunifuAnimatorNS.DecorationType.None);
            this.btnCaja.DisabledColor = System.Drawing.Color.Gray;
            this.btnCaja.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCaja.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnCaja.Iconimage")));
            this.btnCaja.Iconimage_right = null;
            this.btnCaja.Iconimage_right_Selected = null;
            this.btnCaja.Iconimage_Selected = null;
            this.btnCaja.IconMarginLeft = 0;
            this.btnCaja.IconMarginRight = 0;
            this.btnCaja.IconRightVisible = true;
            this.btnCaja.IconRightZoom = 0D;
            this.btnCaja.IconVisible = true;
            this.btnCaja.IconZoom = 90D;
            this.btnCaja.IsTab = false;
            this.btnCaja.Location = new System.Drawing.Point(9, 177);
            this.btnCaja.Name = "btnCaja";
            this.btnCaja.Normalcolor = System.Drawing.Color.Transparent;
            this.btnCaja.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnCaja.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCaja.selected = false;
            this.btnCaja.Size = new System.Drawing.Size(241, 48);
            this.btnCaja.TabIndex = 8;
            this.btnCaja.Text = "      CAJA";
            this.btnCaja.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCaja.Textcolor = System.Drawing.Color.White;
            this.btnCaja.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnInventario
            // 
            this.btnInventario.Active = false;
            this.btnInventario.Activecolor = System.Drawing.Color.Transparent;
            this.btnInventario.BackColor = System.Drawing.Color.Transparent;
            this.btnInventario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInventario.BorderRadius = 0;
            this.btnInventario.ButtonText = "      INVENTARIO";
            this.btnInventario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EfectoIda.SetDecoration(this.btnInventario, BunifuAnimatorNS.DecorationType.None);
            this.btnInventario.DisabledColor = System.Drawing.Color.Gray;
            this.btnInventario.Iconcolor = System.Drawing.Color.Transparent;
            this.btnInventario.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnInventario.Iconimage")));
            this.btnInventario.Iconimage_right = null;
            this.btnInventario.Iconimage_right_Selected = null;
            this.btnInventario.Iconimage_Selected = null;
            this.btnInventario.IconMarginLeft = 0;
            this.btnInventario.IconMarginRight = 0;
            this.btnInventario.IconRightVisible = true;
            this.btnInventario.IconRightZoom = 0D;
            this.btnInventario.IconVisible = true;
            this.btnInventario.IconZoom = 90D;
            this.btnInventario.IsTab = false;
            this.btnInventario.Location = new System.Drawing.Point(9, 123);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Normalcolor = System.Drawing.Color.Transparent;
            this.btnInventario.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnInventario.OnHoverTextColor = System.Drawing.Color.White;
            this.btnInventario.selected = false;
            this.btnInventario.Size = new System.Drawing.Size(241, 48);
            this.btnInventario.TabIndex = 7;
            this.btnInventario.Text = "      INVENTARIO";
            this.btnInventario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventario.Textcolor = System.Drawing.Color.White;
            this.btnInventario.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventario.Click += new System.EventHandler(this.btnInventario_Click);
            // 
            // btnServicio
            // 
            this.btnServicio.Active = false;
            this.btnServicio.Activecolor = System.Drawing.Color.Transparent;
            this.btnServicio.BackColor = System.Drawing.Color.Transparent;
            this.btnServicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnServicio.BorderRadius = 0;
            this.btnServicio.ButtonText = "      SERVICIO";
            this.btnServicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EfectoIda.SetDecoration(this.btnServicio, BunifuAnimatorNS.DecorationType.None);
            this.btnServicio.DisabledColor = System.Drawing.Color.Gray;
            this.btnServicio.Iconcolor = System.Drawing.Color.Transparent;
            this.btnServicio.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnServicio.Iconimage")));
            this.btnServicio.Iconimage_right = null;
            this.btnServicio.Iconimage_right_Selected = null;
            this.btnServicio.Iconimage_Selected = null;
            this.btnServicio.IconMarginLeft = 0;
            this.btnServicio.IconMarginRight = 0;
            this.btnServicio.IconRightVisible = true;
            this.btnServicio.IconRightZoom = 0D;
            this.btnServicio.IconVisible = true;
            this.btnServicio.IconZoom = 90D;
            this.btnServicio.IsTab = false;
            this.btnServicio.Location = new System.Drawing.Point(9, 69);
            this.btnServicio.Name = "btnServicio";
            this.btnServicio.Normalcolor = System.Drawing.Color.Transparent;
            this.btnServicio.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnServicio.OnHoverTextColor = System.Drawing.Color.White;
            this.btnServicio.selected = false;
            this.btnServicio.Size = new System.Drawing.Size(241, 48);
            this.btnServicio.TabIndex = 6;
            this.btnServicio.Text = "      SERVICIO";
            this.btnServicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnServicio.Textcolor = System.Drawing.Color.White;
            this.btnServicio.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServicio.Click += new System.EventHandler(this.btnServicio_Click);
            // 
            // Separador
            // 
            this.Separador.BackColor = System.Drawing.Color.Transparent;
            this.EfectoIda.SetDecoration(this.Separador, BunifuAnimatorNS.DecorationType.None);
            this.Separador.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.Separador.LineThickness = 1;
            this.Separador.Location = new System.Drawing.Point(9, 53);
            this.Separador.Name = "Separador";
            this.Separador.Size = new System.Drawing.Size(250, 1);
            this.Separador.TabIndex = 0;
            this.Separador.Transparency = 255;
            this.Separador.Vertical = false;
            // 
            // pbLogolargo
            // 
            this.pbLogolargo.BackColor = System.Drawing.Color.Transparent;
            this.EfectoIda.SetDecoration(this.pbLogolargo, BunifuAnimatorNS.DecorationType.None);
            this.pbLogolargo.Image = global::DSMarket.Solucion.Properties.Resources.DeveSoft;
            this.pbLogolargo.Location = new System.Drawing.Point(4, 3);
            this.pbLogolargo.Name = "pbLogolargo";
            this.pbLogolargo.Size = new System.Drawing.Size(256, 44);
            this.pbLogolargo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogolargo.TabIndex = 5;
            this.pbLogolargo.TabStop = false;
            // 
            // PRestaurar
            // 
            this.PRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EfectoIda.SetDecoration(this.PRestaurar, BunifuAnimatorNS.DecorationType.None);
            this.PRestaurar.Image = global::DSMarket.Solucion.Properties.Resources.Restore_Window_2_48px;
            this.PRestaurar.Location = new System.Drawing.Point(1326, 29);
            this.PRestaurar.Name = "PRestaurar";
            this.PRestaurar.Size = new System.Drawing.Size(30, 30);
            this.PRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PRestaurar.TabIndex = 4;
            this.PRestaurar.TabStop = false;
            this.toolTip1.SetToolTip(this.PRestaurar, "Restaurar");
            this.PRestaurar.Visible = false;
            this.PRestaurar.Click += new System.EventHandler(this.PRestaurar_Click);
            // 
            // PMinimizar
            // 
            this.PMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EfectoIda.SetDecoration(this.PMinimizar, BunifuAnimatorNS.DecorationType.None);
            this.PMinimizar.Image = global::DSMarket.Solucion.Properties.Resources.Minimize_Window_2_48px;
            this.PMinimizar.Location = new System.Drawing.Point(1294, 29);
            this.PMinimizar.Name = "PMinimizar";
            this.PMinimizar.Size = new System.Drawing.Size(30, 30);
            this.PMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PMinimizar.TabIndex = 3;
            this.PMinimizar.TabStop = false;
            this.toolTip1.SetToolTip(this.PMinimizar, "Minimizar");
            this.PMinimizar.Click += new System.EventHandler(this.PMinimizar_Click);
            // 
            // PMaximizar
            // 
            this.PMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EfectoIda.SetDecoration(this.PMaximizar, BunifuAnimatorNS.DecorationType.None);
            this.PMaximizar.Image = global::DSMarket.Solucion.Properties.Resources.Maximize_Window_2_48px;
            this.PMaximizar.Location = new System.Drawing.Point(1326, 29);
            this.PMaximizar.Name = "PMaximizar";
            this.PMaximizar.Size = new System.Drawing.Size(30, 30);
            this.PMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PMaximizar.TabIndex = 2;
            this.PMaximizar.TabStop = false;
            this.toolTip1.SetToolTip(this.PMaximizar, "Maximizar");
            this.PMaximizar.Click += new System.EventHandler(this.PMaximizar_Click);
            // 
            // PCerrar
            // 
            this.PCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EfectoIda.SetDecoration(this.PCerrar, BunifuAnimatorNS.DecorationType.None);
            this.PCerrar.Image = global::DSMarket.Solucion.Properties.Resources.Close_Window__2_48px;
            this.PCerrar.Location = new System.Drawing.Point(1358, 29);
            this.PCerrar.Name = "PCerrar";
            this.PCerrar.Size = new System.Drawing.Size(30, 30);
            this.PCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PCerrar.TabIndex = 1;
            this.PCerrar.TabStop = false;
            this.toolTip1.SetToolTip(this.PCerrar, "Salir del Sistema");
            this.PCerrar.Click += new System.EventHandler(this.PCerrar_Click);
            // 
            // pictureBox1
            // 
            this.EfectoIda.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Image = global::DSMarket.Solucion.Properties.Resources.Menu_48px;
            this.pictureBox1.Location = new System.Drawing.Point(12, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // EfectoIda
            // 
            this.EfectoIda.AnimationType = BunifuAnimatorNS.AnimationType.Mosaic;
            this.EfectoIda.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 20;
            animation2.Padding = new System.Windows.Forms.Padding(30);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.EfectoIda.DefaultAnimation = animation2;
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 900);
            this.Controls.Add(this.PanelCuerpo);
            this.Controls.Add(this.PanelMenu);
            this.Controls.Add(this.PanelTop);
            this.EfectoIda.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuPrincipal";
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.PanelTop.ResumeLayout(false);
            this.PanelTop.PerformLayout();
            this.PanelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lbLogoCorto)).EndInit();
            this.PanelOpciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogolargo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelTop;
        private System.Windows.Forms.Panel PanelMenu;
        private System.Windows.Forms.Panel PanelCuerpo;
        private System.Windows.Forms.PictureBox PRestaurar;
        private System.Windows.Forms.PictureBox PMinimizar;
        private System.Windows.Forms.PictureBox PMaximizar;
        private System.Windows.Forms.PictureBox PCerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip toolTip1;
        private Bunifu.Framework.UI.BunifuGradientPanel PanelOpciones;
        private System.Windows.Forms.PictureBox pbLogolargo;
        private Bunifu.Framework.UI.BunifuFlatButton btnCerrarSesion;
        private Bunifu.Framework.UI.BunifuFlatButton btnSeguridad;
        private Bunifu.Framework.UI.BunifuFlatButton btnConfiguracion;
        private Bunifu.Framework.UI.BunifuFlatButton btnCaja;
        private Bunifu.Framework.UI.BunifuFlatButton btnInventario;
        private Bunifu.Framework.UI.BunifuFlatButton btnServicio;
        private Bunifu.Framework.UI.BunifuSeparator Separador;
        private Bunifu.Framework.UI.BunifuFlatButton btnSuplidores;
        private Bunifu.Framework.UI.BunifuFlatButton btnNomina;
        private Bunifu.Framework.UI.BunifuFlatButton btnClientes;
        private Bunifu.Framework.UI.BunifuElipse Curva;
        private Bunifu.Framework.UI.BunifuElipse CurvaForms;
        private System.Windows.Forms.PictureBox lbLogoCorto;
        private BunifuAnimatorNS.BunifuTransition EfectoIda;
    }
}