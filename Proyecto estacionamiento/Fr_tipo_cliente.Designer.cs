namespace Proyecto_estacionamiento
{
    partial class Fr_tipo_cliente
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_ModificarT = new System.Windows.Forms.Button();
            this.btn_grabarT = new System.Windows.Forms.Button();
            this.txt_rut_t = new System.Windows.Forms.TextBox();
            this.comboArrendatario = new System.Windows.Forms.ComboBox();
            this.comboArrendador = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_Rut_e = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_EliminarT = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDTIPODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aRRENDADORDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aRRENDATARIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rUTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vTIPOCLIENTEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetV_TipoCliente = new Proyecto_estacionamiento.DataSetV_TipoCliente();
            this.v_TIPO_CLIENTETableAdapter = new Proyecto_estacionamiento.DataSetV_TipoClienteTableAdapters.V_TIPO_CLIENTETableAdapter();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_listarTipo = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vTIPOCLIENTEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetV_TipoCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_ModificarT);
            this.panel1.Controls.Add(this.btn_grabarT);
            this.panel1.Controls.Add(this.txt_rut_t);
            this.panel1.Controls.Add(this.comboArrendatario);
            this.panel1.Controls.Add(this.comboArrendador);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(23, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 128);
            this.panel1.TabIndex = 0;
            // 
            // btn_ModificarT
            // 
            this.btn_ModificarT.Location = new System.Drawing.Point(127, 105);
            this.btn_ModificarT.Name = "btn_ModificarT";
            this.btn_ModificarT.Size = new System.Drawing.Size(75, 23);
            this.btn_ModificarT.TabIndex = 6;
            this.btn_ModificarT.Text = "Modificar";
            this.btn_ModificarT.UseVisualStyleBackColor = true;
            this.btn_ModificarT.Click += new System.EventHandler(this.btn_ModificarT_Click);
            // 
            // btn_grabarT
            // 
            this.btn_grabarT.Location = new System.Drawing.Point(17, 105);
            this.btn_grabarT.Name = "btn_grabarT";
            this.btn_grabarT.Size = new System.Drawing.Size(75, 23);
            this.btn_grabarT.TabIndex = 4;
            this.btn_grabarT.Text = "Grabar";
            this.btn_grabarT.UseVisualStyleBackColor = true;
            this.btn_grabarT.Click += new System.EventHandler(this.btn_grabarT_Click);
            // 
            // txt_rut_t
            // 
            this.txt_rut_t.Location = new System.Drawing.Point(123, 69);
            this.txt_rut_t.Name = "txt_rut_t";
            this.txt_rut_t.Size = new System.Drawing.Size(94, 20);
            this.txt_rut_t.TabIndex = 5;
            // 
            // comboArrendatario
            // 
            this.comboArrendatario.AutoCompleteCustomSource.AddRange(new string[] {
            "Si",
            "No"});
            this.comboArrendatario.FormattingEnabled = true;
            this.comboArrendatario.Items.AddRange(new object[] {
            "SI",
            "NO"});
            this.comboArrendatario.Location = new System.Drawing.Point(127, 39);
            this.comboArrendatario.Name = "comboArrendatario";
            this.comboArrendatario.Size = new System.Drawing.Size(90, 21);
            this.comboArrendatario.TabIndex = 4;
            this.comboArrendatario.Text = "Eliga la Opción";
            // 
            // comboArrendador
            // 
            this.comboArrendador.AutoCompleteCustomSource.AddRange(new string[] {
            "si",
            "no"});
            this.comboArrendador.FormattingEnabled = true;
            this.comboArrendador.Items.AddRange(new object[] {
            "SI",
            "NO"});
            this.comboArrendador.Location = new System.Drawing.Point(123, 7);
            this.comboArrendador.Name = "comboArrendador";
            this.comboArrendador.Size = new System.Drawing.Size(94, 21);
            this.comboArrendador.TabIndex = 3;
            this.comboArrendador.Text = "Eliga la Opción";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Rut";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Arrendatario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Arrendador";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcionesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(593, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Datos del tipo cliente";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 295);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(294, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "***Recuerde que el usuario puede arrendar y ser arrendatario";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txt_Rut_e);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.btn_EliminarT);
            this.panel2.Location = new System.Drawing.Point(52, 215);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(173, 77);
            this.panel2.TabIndex = 4;
            // 
            // txt_Rut_e
            // 
            this.txt_Rut_e.Location = new System.Drawing.Point(83, 19);
            this.txt_Rut_e.Name = "txt_Rut_e";
            this.txt_Rut_e.Size = new System.Drawing.Size(87, 20);
            this.txt_Rut_e.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Rut a eliminar";
            // 
            // btn_EliminarT
            // 
            this.btn_EliminarT.Location = new System.Drawing.Point(98, 50);
            this.btn_EliminarT.Name = "btn_EliminarT";
            this.btn_EliminarT.Size = new System.Drawing.Size(75, 24);
            this.btn_EliminarT.TabIndex = 0;
            this.btn_EliminarT.Text = "Eliminar";
            this.btn_EliminarT.UseVisualStyleBackColor = true;
            this.btn_EliminarT.Click += new System.EventHandler(this.btn_EliminarT_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(87, 212);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Eliminar tipo cliente";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDTIPODataGridViewTextBoxColumn,
            this.aRRENDADORDataGridViewTextBoxColumn,
            this.aRRENDATARIODataGridViewTextBoxColumn,
            this.rUTDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.vTIPOCLIENTEBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(286, 97);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(295, 165);
            this.dataGridView1.TabIndex = 6;
            // 
            // iDTIPODataGridViewTextBoxColumn
            // 
            this.iDTIPODataGridViewTextBoxColumn.DataPropertyName = "ID_TIPO";
            this.iDTIPODataGridViewTextBoxColumn.HeaderText = "ID_TIPO";
            this.iDTIPODataGridViewTextBoxColumn.Name = "iDTIPODataGridViewTextBoxColumn";
            // 
            // aRRENDADORDataGridViewTextBoxColumn
            // 
            this.aRRENDADORDataGridViewTextBoxColumn.DataPropertyName = "ARRENDADOR";
            this.aRRENDADORDataGridViewTextBoxColumn.HeaderText = "ARRENDADOR";
            this.aRRENDADORDataGridViewTextBoxColumn.Name = "aRRENDADORDataGridViewTextBoxColumn";
            // 
            // aRRENDATARIODataGridViewTextBoxColumn
            // 
            this.aRRENDATARIODataGridViewTextBoxColumn.DataPropertyName = "ARRENDATARIO";
            this.aRRENDATARIODataGridViewTextBoxColumn.HeaderText = "ARRENDATARIO";
            this.aRRENDATARIODataGridViewTextBoxColumn.Name = "aRRENDATARIODataGridViewTextBoxColumn";
            // 
            // rUTDataGridViewTextBoxColumn
            // 
            this.rUTDataGridViewTextBoxColumn.DataPropertyName = "RUT";
            this.rUTDataGridViewTextBoxColumn.HeaderText = "RUT";
            this.rUTDataGridViewTextBoxColumn.Name = "rUTDataGridViewTextBoxColumn";
            // 
            // vTIPOCLIENTEBindingSource
            // 
            this.vTIPOCLIENTEBindingSource.DataMember = "V_TIPO_CLIENTE";
            this.vTIPOCLIENTEBindingSource.DataSource = this.dataSetV_TipoCliente;
            // 
            // dataSetV_TipoCliente
            // 
            this.dataSetV_TipoCliente.DataSetName = "DataSetV_TipoCliente";
            this.dataSetV_TipoCliente.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // v_TIPO_CLIENTETableAdapter
            // 
            this.v_TIPO_CLIENTETableAdapter.ClearBeforeFill = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(381, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Visor Tipo Cliente";
            // 
            // btn_listarTipo
            // 
            this.btn_listarTipo.Location = new System.Drawing.Point(394, 268);
            this.btn_listarTipo.Name = "btn_listarTipo";
            this.btn_listarTipo.Size = new System.Drawing.Size(75, 23);
            this.btn_listarTipo.TabIndex = 8;
            this.btn_listarTipo.Text = "Listar todo";
            this.btn_listarTipo.UseVisualStyleBackColor = true;
            this.btn_listarTipo.Click += new System.EventHandler(this.btn_listarTipo_Click);
            // 
            // Fr_tipo_cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 334);
            this.Controls.Add(this.btn_listarTipo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Fr_tipo_cliente";
            this.Text = "Fr_tipo_cliente";
            this.Load += new System.EventHandler(this.Fr_tipo_cliente_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vTIPOCLIENTEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetV_TipoCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_rut_t;
        private System.Windows.Forms.ComboBox comboArrendatario;
        private System.Windows.Forms.ComboBox comboArrendador;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_grabarT;
        private System.Windows.Forms.Button btn_ModificarT;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_Rut_e;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_EliminarT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSetV_TipoCliente dataSetV_TipoCliente;
        private System.Windows.Forms.BindingSource vTIPOCLIENTEBindingSource;
        private DataSetV_TipoClienteTableAdapters.V_TIPO_CLIENTETableAdapter v_TIPO_CLIENTETableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDTIPODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aRRENDADORDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aRRENDATARIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rUTDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_listarTipo;
    }
}