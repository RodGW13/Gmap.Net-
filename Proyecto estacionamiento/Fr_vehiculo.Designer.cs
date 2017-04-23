namespace Proyecto_estacionamiento
{
    partial class Fr_vehiculo
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
            this.btn_Grabar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Patente = new System.Windows.Forms.TextBox();
            this.txt_Marca = new System.Windows.Forms.TextBox();
            this.txt_Color = new System.Windows.Forms.TextBox();
            this.txt_Descripcion = new System.Windows.Forms.TextBox();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Patente_E = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.volverAtrasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pATENTEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mARCADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOLORDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dESCRIPCIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vVEHICULOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetVehiculo = new Proyecto_estacionamiento.DataSetVehiculo();
            this.v_VEHICULOTableAdapter = new Proyecto_estacionamiento.DataSetVehiculoTableAdapters.V_VEHICULOTableAdapter();
            this.btn_listado_v = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vVEHICULOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetVehiculo)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Grabar
            // 
            this.btn_Grabar.Location = new System.Drawing.Point(6, 151);
            this.btn_Grabar.Name = "btn_Grabar";
            this.btn_Grabar.Size = new System.Drawing.Size(75, 23);
            this.btn_Grabar.TabIndex = 0;
            this.btn_Grabar.Text = "Grabar";
            this.btn_Grabar.UseVisualStyleBackColor = true;
            this.btn_Grabar.Click += new System.EventHandler(this.btn_Grabar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Patente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Marca";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Color";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Descripción";
            // 
            // txt_Patente
            // 
            this.txt_Patente.Location = new System.Drawing.Point(112, 9);
            this.txt_Patente.Name = "txt_Patente";
            this.txt_Patente.Size = new System.Drawing.Size(100, 20);
            this.txt_Patente.TabIndex = 5;
            // 
            // txt_Marca
            // 
            this.txt_Marca.Location = new System.Drawing.Point(112, 38);
            this.txt_Marca.Name = "txt_Marca";
            this.txt_Marca.Size = new System.Drawing.Size(100, 20);
            this.txt_Marca.TabIndex = 6;
            // 
            // txt_Color
            // 
            this.txt_Color.Location = new System.Drawing.Point(112, 75);
            this.txt_Color.Name = "txt_Color";
            this.txt_Color.Size = new System.Drawing.Size(100, 20);
            this.txt_Color.TabIndex = 7;
            // 
            // txt_Descripcion
            // 
            this.txt_Descripcion.Location = new System.Drawing.Point(112, 113);
            this.txt_Descripcion.Name = "txt_Descripcion";
            this.txt_Descripcion.Size = new System.Drawing.Size(100, 20);
            this.txt_Descripcion.TabIndex = 8;
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Location = new System.Drawing.Point(84, 188);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(75, 23);
            this.btn_limpiar.TabIndex = 9;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // btn_modificar
            // 
            this.btn_modificar.Location = new System.Drawing.Point(151, 151);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(75, 23);
            this.btn_modificar.TabIndex = 10;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.UseVisualStyleBackColor = true;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Location = new System.Drawing.Point(68, 73);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(75, 23);
            this.btn_Eliminar.TabIndex = 11;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txt_Patente_E);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btn_Eliminar);
            this.panel1.Location = new System.Drawing.Point(69, 276);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(208, 103);
            this.panel1.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Patente a Eliminar";
            // 
            // txt_Patente_E
            // 
            this.txt_Patente_E.Location = new System.Drawing.Point(97, 25);
            this.txt_Patente_E.Name = "txt_Patente_E";
            this.txt_Patente_E.Size = new System.Drawing.Size(100, 20);
            this.txt_Patente_E.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Eliminar Vehículo";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txt_Patente);
            this.panel2.Controls.Add(this.txt_Marca);
            this.panel2.Controls.Add(this.btn_modificar);
            this.panel2.Controls.Add(this.btn_limpiar);
            this.panel2.Controls.Add(this.txt_Color);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txt_Descripcion);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.btn_Grabar);
            this.panel2.Location = new System.Drawing.Point(51, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(295, 211);
            this.panel2.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(81, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(113, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Datos Vehículo";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcionesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(732, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.volverAtrasToolStripMenuItem});
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // volverAtrasToolStripMenuItem
            // 
            this.volverAtrasToolStripMenuItem.Name = "volverAtrasToolStripMenuItem";
            this.volverAtrasToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.volverAtrasToolStripMenuItem.Text = "Volver Atras";
            this.volverAtrasToolStripMenuItem.Click += new System.EventHandler(this.volverAtrasToolStripMenuItem_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(491, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Visor Vehículos";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pATENTEDataGridViewTextBoxColumn,
            this.mARCADataGridViewTextBoxColumn,
            this.cOLORDataGridViewTextBoxColumn,
            this.dESCRIPCIONDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.vVEHICULOBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(371, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(361, 150);
            this.dataGridView1.TabIndex = 16;
            // 
            // pATENTEDataGridViewTextBoxColumn
            // 
            this.pATENTEDataGridViewTextBoxColumn.DataPropertyName = "PATENTE";
            this.pATENTEDataGridViewTextBoxColumn.HeaderText = "PATENTE";
            this.pATENTEDataGridViewTextBoxColumn.Name = "pATENTEDataGridViewTextBoxColumn";
            // 
            // mARCADataGridViewTextBoxColumn
            // 
            this.mARCADataGridViewTextBoxColumn.DataPropertyName = "MARCA";
            this.mARCADataGridViewTextBoxColumn.HeaderText = "MARCA";
            this.mARCADataGridViewTextBoxColumn.Name = "mARCADataGridViewTextBoxColumn";
            // 
            // cOLORDataGridViewTextBoxColumn
            // 
            this.cOLORDataGridViewTextBoxColumn.DataPropertyName = "COLOR";
            this.cOLORDataGridViewTextBoxColumn.HeaderText = "COLOR";
            this.cOLORDataGridViewTextBoxColumn.Name = "cOLORDataGridViewTextBoxColumn";
            // 
            // dESCRIPCIONDataGridViewTextBoxColumn
            // 
            this.dESCRIPCIONDataGridViewTextBoxColumn.DataPropertyName = "DESCRIPCION";
            this.dESCRIPCIONDataGridViewTextBoxColumn.HeaderText = "DESCRIPCION";
            this.dESCRIPCIONDataGridViewTextBoxColumn.Name = "dESCRIPCIONDataGridViewTextBoxColumn";
            // 
            // vVEHICULOBindingSource
            // 
            this.vVEHICULOBindingSource.DataMember = "V_VEHICULO";
            this.vVEHICULOBindingSource.DataSource = this.dataSetVehiculo;
            // 
            // dataSetVehiculo
            // 
            this.dataSetVehiculo.DataSetName = "DataSetVehiculo";
            this.dataSetVehiculo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // v_VEHICULOTableAdapter
            // 
            this.v_VEHICULOTableAdapter.ClearBeforeFill = true;
            // 
            // btn_listado_v
            // 
            this.btn_listado_v.Location = new System.Drawing.Point(471, 236);
            this.btn_listado_v.Name = "btn_listado_v";
            this.btn_listado_v.Size = new System.Drawing.Size(101, 23);
            this.btn_listado_v.TabIndex = 17;
            this.btn_listado_v.Text = "Actualizar Listado";
            this.btn_listado_v.UseVisualStyleBackColor = true;
            this.btn_listado_v.Click += new System.EventHandler(this.btn_listado_v_Click);
            // 
            // Fr_vehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 362);
            this.Controls.Add(this.btn_listado_v);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Fr_vehiculo";
            this.Text = "Fr_vehiculo";
            this.Load += new System.EventHandler(this.Fr_vehiculo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vVEHICULOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetVehiculo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Grabar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Patente;
        private System.Windows.Forms.TextBox txt_Marca;
        private System.Windows.Forms.TextBox txt_Color;
        private System.Windows.Forms.TextBox txt_Descripcion;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Patente_E;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem volverAtrasToolStripMenuItem;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSetVehiculo dataSetVehiculo;
        private System.Windows.Forms.BindingSource vVEHICULOBindingSource;
        private DataSetVehiculoTableAdapters.V_VEHICULOTableAdapter v_VEHICULOTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn pATENTEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mARCADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cOLORDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESCRIPCIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_listado_v;
    }
}