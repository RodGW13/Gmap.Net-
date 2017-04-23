namespace Proyecto_estacionamiento
{
    partial class Fr_Lista_Estacionamiento
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.volverAtrasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboEstado = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDLISTADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDESTACIONAMIENTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eSTADODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vLISTAESTACIONAMIENTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetListado_es = new Proyecto_estacionamiento.DataSetListado_es();
            this.v_LISTA_ESTACIONAMIENTOTableAdapter = new Proyecto_estacionamiento.DataSetListado_esTableAdapters.V_LISTA_ESTACIONAMIENTOTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_actualizar_li = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Id_listado = new System.Windows.Forms.TextBox();
            this.txt_id_es = new System.Windows.Forms.TextBox();
            this.btn_Grabar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vLISTAESTACIONAMIENTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetListado_es)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcionesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(481, 24);
            this.menuStrip1.TabIndex = 0;
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
            // comboEstado
            // 
            this.comboEstado.FormattingEnabled = true;
            this.comboEstado.Items.AddRange(new object[] {
            "Arrendado",
            "Pendiente",
            "Libre "});
            this.comboEstado.Location = new System.Drawing.Point(165, 127);
            this.comboEstado.Name = "comboEstado";
            this.comboEstado.Size = new System.Drawing.Size(79, 21);
            this.comboEstado.TabIndex = 18;
            this.comboEstado.Text = "Seleccionar";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Estado";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDLISTADataGridViewTextBoxColumn,
            this.iDESTACIONAMIENTODataGridViewTextBoxColumn,
            this.eSTADODataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.vLISTAESTACIONAMIENTOBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(33, 224);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(358, 150);
            this.dataGridView1.TabIndex = 19;
            // 
            // iDLISTADataGridViewTextBoxColumn
            // 
            this.iDLISTADataGridViewTextBoxColumn.DataPropertyName = "ID_LISTA";
            this.iDLISTADataGridViewTextBoxColumn.HeaderText = "ID_LISTA";
            this.iDLISTADataGridViewTextBoxColumn.Name = "iDLISTADataGridViewTextBoxColumn";
            // 
            // iDESTACIONAMIENTODataGridViewTextBoxColumn
            // 
            this.iDESTACIONAMIENTODataGridViewTextBoxColumn.DataPropertyName = "ID_ESTACIONAMIENTO";
            this.iDESTACIONAMIENTODataGridViewTextBoxColumn.HeaderText = "ID_ESTACIONAMIENTO";
            this.iDESTACIONAMIENTODataGridViewTextBoxColumn.Name = "iDESTACIONAMIENTODataGridViewTextBoxColumn";
            // 
            // eSTADODataGridViewTextBoxColumn
            // 
            this.eSTADODataGridViewTextBoxColumn.DataPropertyName = "ESTADO";
            this.eSTADODataGridViewTextBoxColumn.HeaderText = "ESTADO";
            this.eSTADODataGridViewTextBoxColumn.Name = "eSTADODataGridViewTextBoxColumn";
            // 
            // vLISTAESTACIONAMIENTOBindingSource
            // 
            this.vLISTAESTACIONAMIENTOBindingSource.DataMember = "V_LISTA_ESTACIONAMIENTO";
            this.vLISTAESTACIONAMIENTOBindingSource.DataSource = this.dataSetListado_es;
            // 
            // dataSetListado_es
            // 
            this.dataSetListado_es.DataSetName = "DataSetListado_es";
            this.dataSetListado_es.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // v_LISTA_ESTACIONAMIENTOTableAdapter
            // 
            this.v_LISTA_ESTACIONAMIENTOTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Visor Listado";
            // 
            // btn_actualizar_li
            // 
            this.btn_actualizar_li.Location = new System.Drawing.Point(222, 194);
            this.btn_actualizar_li.Name = "btn_actualizar_li";
            this.btn_actualizar_li.Size = new System.Drawing.Size(112, 23);
            this.btn_actualizar_li.TabIndex = 21;
            this.btn_actualizar_li.Text = "Actualizar Listado";
            this.btn_actualizar_li.UseVisualStyleBackColor = true;
            this.btn_actualizar_li.Click += new System.EventHandler(this.btn_actualizar_li_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Id_Estacionamiento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Id_Lista";
            // 
            // txt_Id_listado
            // 
            this.txt_Id_listado.Location = new System.Drawing.Point(144, 57);
            this.txt_Id_listado.Name = "txt_Id_listado";
            this.txt_Id_listado.Size = new System.Drawing.Size(100, 20);
            this.txt_Id_listado.TabIndex = 24;
            // 
            // txt_id_es
            // 
            this.txt_id_es.Location = new System.Drawing.Point(144, 94);
            this.txt_id_es.Name = "txt_id_es";
            this.txt_id_es.Size = new System.Drawing.Size(100, 20);
            this.txt_id_es.TabIndex = 25;
            // 
            // btn_Grabar
            // 
            this.btn_Grabar.Location = new System.Drawing.Point(296, 54);
            this.btn_Grabar.Name = "btn_Grabar";
            this.btn_Grabar.Size = new System.Drawing.Size(75, 23);
            this.btn_Grabar.TabIndex = 26;
            this.btn_Grabar.Text = "Grabar";
            this.btn_Grabar.UseVisualStyleBackColor = true;
            this.btn_Grabar.Click += new System.EventHandler(this.btn_Grabar_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(296, 139);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(75, 23);
            this.btn_eliminar.TabIndex = 27;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_modificar
            // 
            this.btn_modificar.Location = new System.Drawing.Point(296, 97);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(75, 23);
            this.btn_modificar.TabIndex = 28;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.UseVisualStyleBackColor = true;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // Fr_Lista_Estacionamiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 375);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_Grabar);
            this.Controls.Add(this.txt_id_es);
            this.Controls.Add(this.txt_Id_listado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_actualizar_li);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboEstado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Fr_Lista_Estacionamiento";
            this.Text = "Lista_Estacionamiento";
            this.Load += new System.EventHandler(this.Fr_Lista_Estacionamiento_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vLISTAESTACIONAMIENTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetListado_es)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem volverAtrasToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboEstado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSetListado_es dataSetListado_es;
        private System.Windows.Forms.BindingSource vLISTAESTACIONAMIENTOBindingSource;
        private DataSetListado_esTableAdapters.V_LISTA_ESTACIONAMIENTOTableAdapter v_LISTA_ESTACIONAMIENTOTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDLISTADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDESTACIONAMIENTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eSTADODataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_actualizar_li;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Id_listado;
        private System.Windows.Forms.TextBox txt_id_es;
        private System.Windows.Forms.Button btn_Grabar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_modificar;
    }
}