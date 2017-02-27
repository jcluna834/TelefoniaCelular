namespace TelefoniaCelular3CWindows
{
    partial class MenuTelefoniaCelular
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuTelefoniaCelular));
            this.btnInsertar = new System.Windows.Forms.Button();
            this.comInsetar = new System.Windows.Forms.ComboBox();
            this.comEliminar = new System.Windows.Forms.ComboBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtEliminar = new System.Windows.Forms.TextBox();
            this.lblerror = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.comConsultar = new System.Windows.Forms.ComboBox();
            this.dvgDatos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnReportes = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Operaciones = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape5 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape4 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape3 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            ((System.ComponentModel.ISupportInitialize)(this.dvgDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(476, 146);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(75, 37);
            this.btnInsertar.TabIndex = 7;
            this.btnInsertar.Text = "INSERTAR/ACTUALIZAR";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // comInsetar
            // 
            this.comInsetar.FormattingEnabled = true;
            this.comInsetar.Items.AddRange(new object[] {
            "Ciudad",
            "Cliente"});
            this.comInsetar.Location = new System.Drawing.Point(571, 155);
            this.comInsetar.Name = "comInsetar";
            this.comInsetar.Size = new System.Drawing.Size(121, 21);
            this.comInsetar.TabIndex = 11;
            // 
            // comEliminar
            // 
            this.comEliminar.FormattingEnabled = true;
            this.comEliminar.Items.AddRange(new object[] {
            "Ciudad",
            "Cliente"});
            this.comEliminar.Location = new System.Drawing.Point(571, 211);
            this.comEliminar.Name = "comEliminar";
            this.comEliminar.Size = new System.Drawing.Size(121, 21);
            this.comEliminar.TabIndex = 12;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(476, 211);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 13;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtEliminar
            // 
            this.txtEliminar.Location = new System.Drawing.Point(571, 238);
            this.txtEliminar.Name = "txtEliminar";
            this.txtEliminar.Size = new System.Drawing.Size(100, 20);
            this.txtEliminar.TabIndex = 14;
            // 
            // lblerror
            // 
            this.lblerror.AutoSize = true;
            this.lblerror.Location = new System.Drawing.Point(473, 269);
            this.lblerror.Name = "lblerror";
            this.lblerror.Size = new System.Drawing.Size(0, 13);
            this.lblerror.TabIndex = 15;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(12, 29);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(103, 23);
            this.btnConsultar.TabIndex = 16;
            this.btnConsultar.Text = "CONSULTAR";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // comConsultar
            // 
            this.comConsultar.FormattingEnabled = true;
            this.comConsultar.Items.AddRange(new object[] {
            "Ciudad",
            "Cliente"});
            this.comConsultar.Location = new System.Drawing.Point(142, 29);
            this.comConsultar.Name = "comConsultar";
            this.comConsultar.Size = new System.Drawing.Size(121, 21);
            this.comConsultar.TabIndex = 0;
            // 
            // dvgDatos
            // 
            this.dvgDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgDatos.Location = new System.Drawing.Point(12, 58);
            this.dvgDatos.Name = "dvgDatos";
            this.dvgDatos.Size = new System.Drawing.Size(375, 304);
            this.dvgDatos.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(487, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Id a Eliminar";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(610, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "FUNCIONES";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnReportes
            // 
            this.btnReportes.Location = new System.Drawing.Point(501, 29);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(75, 23);
            this.btnReportes.TabIndex = 21;
            this.btnReportes.Text = "REPORTES";
            this.btnReportes.UseVisualStyleBackColor = true;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(338, 368);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 22;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(-5, 385);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 32);
            this.label2.TabIndex = 23;
            this.label2.Text = "Hecho Por:  Gabriel Muñoz\r\n                      Julio César Luna";
            // 
            // Operaciones
            // 
            this.Operaciones.AutoSize = true;
            this.Operaciones.BackColor = System.Drawing.Color.Aqua;
            this.Operaciones.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Operaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Operaciones.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Operaciones.Location = new System.Drawing.Point(485, 99);
            this.Operaciones.Name = "Operaciones";
            this.Operaciones.Size = new System.Drawing.Size(105, 22);
            this.Operaciones.TabIndex = 24;
            this.Operaciones.Text = "Operaciones ";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape5,
            this.lineShape4,
            this.lineShape3,
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(714, 417);
            this.shapeContainer1.TabIndex = 25;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape5
            // 
            this.lineShape5.BorderColor = System.Drawing.Color.Aqua;
            this.lineShape5.BorderWidth = 4;
            this.lineShape5.Name = "lineShape5";
            this.lineShape5.X1 = 701;
            this.lineShape5.X2 = 702;
            this.lineShape5.Y1 = 111;
            this.lineShape5.Y2 = 292;
            // 
            // lineShape4
            // 
            this.lineShape4.BorderColor = System.Drawing.Color.Aqua;
            this.lineShape4.BorderWidth = 4;
            this.lineShape4.Name = "lineShape4";
            this.lineShape4.X1 = 427;
            this.lineShape4.X2 = 427;
            this.lineShape4.Y1 = 110;
            this.lineShape4.Y2 = 293;
            // 
            // lineShape3
            // 
            this.lineShape3.BorderColor = System.Drawing.Color.Aqua;
            this.lineShape3.BorderWidth = 4;
            this.lineShape3.Name = "lineShape3";
            this.lineShape3.X1 = 428;
            this.lineShape3.X2 = 703;
            this.lineShape3.Y1 = 291;
            this.lineShape3.Y2 = 291;
            // 
            // lineShape2
            // 
            this.lineShape2.BorderColor = System.Drawing.Color.Aqua;
            this.lineShape2.BorderWidth = 4;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 428;
            this.lineShape2.X2 = 703;
            this.lineShape2.Y1 = 112;
            this.lineShape2.Y2 = 112;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 0;
            this.lineShape1.X2 = 75;
            this.lineShape1.Y1 = 0;
            this.lineShape1.Y2 = 23;
            // 
            // MenuTelefoniaCelular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(714, 417);
            this.Controls.Add(this.Operaciones);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnReportes);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dvgDatos);
            this.Controls.Add(this.comConsultar);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.lblerror);
            this.Controls.Add(this.txtEliminar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.comEliminar);
            this.Controls.Add(this.comInsetar);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.shapeContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuTelefoniaCelular";
            this.Text = "TELEFONIA CELULAR";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.ComboBox comInsetar;
        private System.Windows.Forms.ComboBox comEliminar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtEliminar;
        private System.Windows.Forms.Label lblerror;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.ComboBox comConsultar;
        private System.Windows.Forms.DataGridView dvgDatos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Operaciones;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape5;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape4;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape3;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
    }
}

