namespace Gui_Modernista
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.barratitulo = new System.Windows.Forms.Panel();
            this.btnmaximizar = new System.Windows.Forms.PictureBox();
            this.btnminimizar = new System.Windows.Forms.PictureBox();
            this.btnrestaurar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.menuvertical = new System.Windows.Forms.Panel();
            this.SubmenuReportes = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btnrptventa = new System.Windows.Forms.Button();
            this.panel11 = new System.Windows.Forms.Panel();
            this.btnrptpagos = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.btnrptcompra = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.btnreporte = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelcontenedor = new System.Windows.Forms.Panel();
            this.barratitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnmaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnminimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnrestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.menuvertical.SuspendLayout();
            this.SubmenuReportes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // barratitulo
            // 
            this.barratitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.barratitulo.Controls.Add(this.btnmaximizar);
            this.barratitulo.Controls.Add(this.btnminimizar);
            this.barratitulo.Controls.Add(this.btnrestaurar);
            this.barratitulo.Controls.Add(this.btnCerrar);
            this.barratitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.barratitulo.Location = new System.Drawing.Point(0, 0);
            this.barratitulo.Name = "barratitulo";
            this.barratitulo.Size = new System.Drawing.Size(1300, 35);
            this.barratitulo.TabIndex = 0;
            this.barratitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Barratitulo_MouseDown);
            // 
            // btnmaximizar
            // 
            this.btnmaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnmaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnmaximizar.Image = global::Gui_Modernista.Properties.Resources.maxi;
            this.btnmaximizar.Location = new System.Drawing.Point(1221, 4);
            this.btnmaximizar.Name = "btnmaximizar";
            this.btnmaximizar.Size = new System.Drawing.Size(25, 25);
            this.btnmaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnmaximizar.TabIndex = 3;
            this.btnmaximizar.TabStop = false;
            this.btnmaximizar.Click += new System.EventHandler(this.Btnmaximizar_Click);
            // 
            // btnminimizar
            // 
            this.btnminimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnminimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnminimizar.Image = global::Gui_Modernista.Properties.Resources.minimazar;
            this.btnminimizar.Location = new System.Drawing.Point(1175, 4);
            this.btnminimizar.Name = "btnminimizar";
            this.btnminimizar.Size = new System.Drawing.Size(25, 25);
            this.btnminimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnminimizar.TabIndex = 2;
            this.btnminimizar.TabStop = false;
            this.btnminimizar.Click += new System.EventHandler(this.Btnminimizar_Click);
            // 
            // btnrestaurar
            // 
            this.btnrestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnrestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnrestaurar.Image = global::Gui_Modernista.Properties.Resources.res;
            this.btnrestaurar.Location = new System.Drawing.Point(1221, 4);
            this.btnrestaurar.Name = "btnrestaurar";
            this.btnrestaurar.Size = new System.Drawing.Size(25, 25);
            this.btnrestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnrestaurar.TabIndex = 1;
            this.btnrestaurar.TabStop = false;
            this.btnrestaurar.Visible = false;
            this.btnrestaurar.Click += new System.EventHandler(this.Btnrestaurar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = global::Gui_Modernista.Properties.Resources.cerrar;
            this.btnCerrar.Location = new System.Drawing.Point(1263, 4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(25, 25);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // menuvertical
            // 
            this.menuvertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.menuvertical.Controls.Add(this.SubmenuReportes);
            this.menuvertical.Controls.Add(this.panel5);
            this.menuvertical.Controls.Add(this.button6);
            this.menuvertical.Controls.Add(this.panel7);
            this.menuvertical.Controls.Add(this.panel3);
            this.menuvertical.Controls.Add(this.button5);
            this.menuvertical.Controls.Add(this.btnreporte);
            this.menuvertical.Controls.Add(this.panel6);
            this.menuvertical.Controls.Add(this.panel4);
            this.menuvertical.Controls.Add(this.button4);
            this.menuvertical.Controls.Add(this.button3);
            this.menuvertical.Controls.Add(this.panel2);
            this.menuvertical.Controls.Add(this.button2);
            this.menuvertical.Controls.Add(this.panel1);
            this.menuvertical.Controls.Add(this.button1);
            this.menuvertical.Controls.Add(this.pictureBox1);
            this.menuvertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuvertical.Location = new System.Drawing.Point(0, 35);
            this.menuvertical.Name = "menuvertical";
            this.menuvertical.Size = new System.Drawing.Size(279, 615);
            this.menuvertical.TabIndex = 1;
            // 
            // SubmenuReportes
            // 
            this.SubmenuReportes.Controls.Add(this.panel9);
            this.SubmenuReportes.Controls.Add(this.btnrptventa);
            this.SubmenuReportes.Controls.Add(this.panel11);
            this.SubmenuReportes.Controls.Add(this.btnrptpagos);
            this.SubmenuReportes.Controls.Add(this.panel10);
            this.SubmenuReportes.Controls.Add(this.btnrptcompra);
            this.SubmenuReportes.Location = new System.Drawing.Point(43, 490);
            this.SubmenuReportes.Name = "SubmenuReportes";
            this.SubmenuReportes.Size = new System.Drawing.Size(233, 100);
            this.SubmenuReportes.TabIndex = 0;
            this.SubmenuReportes.Visible = false;
            this.SubmenuReportes.Paint += new System.Windows.Forms.PaintEventHandler(this.SubmenuReportes_Paint);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel9.Location = new System.Drawing.Point(0, 4);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(5, 28);
            this.panel9.TabIndex = 11;
            // 
            // btnrptventa
            // 
            this.btnrptventa.FlatAppearance.BorderSize = 0;
            this.btnrptventa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnrptventa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnrptventa.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrptventa.ForeColor = System.Drawing.Color.White;
            this.btnrptventa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnrptventa.Location = new System.Drawing.Point(3, 3);
            this.btnrptventa.Name = "btnrptventa";
            this.btnrptventa.Size = new System.Drawing.Size(233, 31);
            this.btnrptventa.TabIndex = 7;
            this.btnrptventa.Text = "Reporte Ventas";
            this.btnrptventa.UseVisualStyleBackColor = true;
            this.btnrptventa.Click += new System.EventHandler(this.Btnrptventa_Click);
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel11.Location = new System.Drawing.Point(0, 72);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(5, 28);
            this.panel11.TabIndex = 12;
            // 
            // btnrptpagos
            // 
            this.btnrptpagos.FlatAppearance.BorderSize = 0;
            this.btnrptpagos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnrptpagos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnrptpagos.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrptpagos.ForeColor = System.Drawing.Color.White;
            this.btnrptpagos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnrptpagos.Location = new System.Drawing.Point(3, 69);
            this.btnrptpagos.Name = "btnrptpagos";
            this.btnrptpagos.Size = new System.Drawing.Size(230, 31);
            this.btnrptpagos.TabIndex = 13;
            this.btnrptpagos.Text = "Reporte Pagos";
            this.btnrptpagos.UseVisualStyleBackColor = true;
            this.btnrptpagos.Click += new System.EventHandler(this.Btnrptpagos_Click);
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel10.Location = new System.Drawing.Point(0, 38);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(5, 28);
            this.panel10.TabIndex = 12;
            // 
            // btnrptcompra
            // 
            this.btnrptcompra.FlatAppearance.BorderSize = 0;
            this.btnrptcompra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnrptcompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnrptcompra.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrptcompra.ForeColor = System.Drawing.Color.White;
            this.btnrptcompra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnrptcompra.Location = new System.Drawing.Point(3, 37);
            this.btnrptcompra.Name = "btnrptcompra";
            this.btnrptcompra.Size = new System.Drawing.Size(233, 31);
            this.btnrptcompra.TabIndex = 12;
            this.btnrptcompra.Text = "Reporte Compras";
            this.btnrptcompra.UseVisualStyleBackColor = true;
            this.btnrptcompra.Click += new System.EventHandler(this.Btnrptcompra_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel5.Location = new System.Drawing.Point(0, 357);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(5, 32);
            this.panel5.TabIndex = 8;
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Image = global::Gui_Modernista.Properties.Resources.producto1;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(4, 357);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(275, 32);
            this.button6.TabIndex = 9;
            this.button6.Text = "Empleados";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel7.Location = new System.Drawing.Point(1, 452);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(5, 32);
            this.panel7.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel3.Location = new System.Drawing.Point(1, 310);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(5, 32);
            this.panel3.TabIndex = 7;
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Image = global::Gui_Modernista.Properties.Resources.compras;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(4, 310);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(275, 32);
            this.button5.TabIndex = 7;
            this.button5.Text = "Compras";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // btnreporte
            // 
            this.btnreporte.FlatAppearance.BorderSize = 0;
            this.btnreporte.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnreporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnreporte.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreporte.ForeColor = System.Drawing.Color.White;
            this.btnreporte.Image = global::Gui_Modernista.Properties.Resources.reportes;
            this.btnreporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnreporte.Location = new System.Drawing.Point(4, 452);
            this.btnreporte.Name = "btnreporte";
            this.btnreporte.Size = new System.Drawing.Size(275, 32);
            this.btnreporte.TabIndex = 10;
            this.btnreporte.Text = "Reportes";
            this.btnreporte.UseVisualStyleBackColor = true;
            this.btnreporte.Click += new System.EventHandler(this.Btnreporte_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel6.Location = new System.Drawing.Point(0, 404);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(5, 32);
            this.panel6.TabIndex = 10;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel4.Location = new System.Drawing.Point(1, 262);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(5, 32);
            this.panel4.TabIndex = 6;
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Image = global::Gui_Modernista.Properties.Resources.pagos;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(4, 404);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(275, 34);
            this.button4.TabIndex = 6;
            this.button4.Text = "Pagos";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = global::Gui_Modernista.Properties.Resources.clientes;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(4, 262);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(275, 32);
            this.button3.TabIndex = 5;
            this.button3.Text = "Clientes";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel2.Location = new System.Drawing.Point(1, 214);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 32);
            this.panel2.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = global::Gui_Modernista.Properties.Resources.venta;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(4, 214);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(275, 32);
            this.button2.TabIndex = 3;
            this.button2.Text = "Ventas";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel1.Location = new System.Drawing.Point(1, 166);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 32);
            this.panel1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::Gui_Modernista.Properties.Resources.producto1;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(4, 166);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(275, 32);
            this.button1.TabIndex = 1;
            this.button1.Text = "Productos";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Gui_Modernista.Properties.Resources.LOGOS;
            this.pictureBox1.Location = new System.Drawing.Point(0, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(279, 115);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelcontenedor
            // 
            this.panelcontenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.panelcontenedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelcontenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelcontenedor.Location = new System.Drawing.Point(279, 35);
            this.panelcontenedor.Name = "panelcontenedor";
            this.panelcontenedor.Size = new System.Drawing.Size(1021, 615);
            this.panelcontenedor.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 650);
            this.Controls.Add(this.panelcontenedor);
            this.Controls.Add(this.menuvertical);
            this.Controls.Add(this.barratitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.barratitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnmaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnminimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnrestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.menuvertical.ResumeLayout(false);
            this.SubmenuReportes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel barratitulo;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Panel menuvertical;
        private System.Windows.Forms.Panel panelcontenedor;
        private System.Windows.Forms.PictureBox btnmaximizar;
        private System.Windows.Forms.PictureBox btnminimizar;
        private System.Windows.Forms.PictureBox btnrestaurar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnreporte;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel SubmenuReportes;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button btnrptventa;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Button btnrptpagos;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button btnrptcompra;
    }
}

