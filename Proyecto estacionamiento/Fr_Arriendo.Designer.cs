namespace Proyecto_estacionamiento
{
    partial class Fr_Arriendo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_grabar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_id_tipo_c = new System.Windows.Forms.TextBox();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDARRIENDODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fECHAINICIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fECHATERMINODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aRRENDATARIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tIPOCLIENTEIDTIPODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vARRIENDOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetV_Arriendo = new Proyecto_estacionamiento.DataSetV_Arriendo();
            this.v_ARRIENDOTableAdapter = new Proyecto_estacionamiento.DataSetV_ArriendoTableAdapters.V_ARRIENDOTableAdapter();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Arriendo = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTime_Ter = new System.Windows.Forms.DateTimePicker();
            this.dateTime_Ini = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.volverAtrasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label17 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.btn_zoom_ou = new System.Windows.Forms.Button();
            this.btn_zoom_i = new System.Windows.Forms.Button();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vARRIENDOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetV_Arriendo)).BeginInit();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha Inicio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha Termino";
            // 
            // btn_grabar
            // 
            this.btn_grabar.Location = new System.Drawing.Point(141, 138);
            this.btn_grabar.Name = "btn_grabar";
            this.btn_grabar.Size = new System.Drawing.Size(75, 23);
            this.btn_grabar.TabIndex = 2;
            this.btn_grabar.Text = "Guardar";
            this.btn_grabar.UseVisualStyleBackColor = true;
            this.btn_grabar.Click += new System.EventHandler(this.btn_grabar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Arrendatario";
            // 
            // txt_id_tipo_c
            // 
            this.txt_id_tipo_c.Location = new System.Drawing.Point(120, 70);
            this.txt_id_tipo_c.Name = "txt_id_tipo_c";
            this.txt_id_tipo_c.Size = new System.Drawing.Size(100, 20);
            this.txt_id_tipo_c.TabIndex = 7;
            // 
            // btn_modificar
            // 
            this.btn_modificar.Location = new System.Drawing.Point(320, 110);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(75, 23);
            this.btn_modificar.TabIndex = 8;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.UseVisualStyleBackColor = true;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Estacionamiento";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(120, 106);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 10;
            // 
            // gMapControl1
            // 
            this.gMapControl1.Bearing = 0F;
            this.gMapControl1.CanDragMap = true;
            this.gMapControl1.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl1.GrayScaleMode = false;
            this.gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl1.LevelsKeepInMemmory = 5;
            this.gMapControl1.Location = new System.Drawing.Point(508, 67);
            this.gMapControl1.MarkersEnabled = true;
            this.gMapControl1.MaxZoom = 2;
            this.gMapControl1.MinZoom = 2;
            this.gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControl1.Name = "gMapControl1";
            this.gMapControl1.NegativeMode = false;
            this.gMapControl1.PolygonsEnabled = true;
            this.gMapControl1.RetryLoadTile = 0;
            this.gMapControl1.RoutesEnabled = true;
            this.gMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControl1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl1.ShowTileGridLines = false;
            this.gMapControl1.Size = new System.Drawing.Size(551, 494);
            this.gMapControl1.TabIndex = 11;
            this.gMapControl1.Zoom = 0D;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDARRIENDODataGridViewTextBoxColumn,
            this.fECHAINICIODataGridViewTextBoxColumn,
            this.fECHATERMINODataGridViewTextBoxColumn,
            this.aRRENDATARIODataGridViewTextBoxColumn,
            this.tIPOCLIENTEIDTIPODataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.vARRIENDOBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(26, 256);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(459, 291);
            this.dataGridView1.TabIndex = 12;
            // 
            // iDARRIENDODataGridViewTextBoxColumn
            // 
            this.iDARRIENDODataGridViewTextBoxColumn.DataPropertyName = "ID_ARRIENDO";
            this.iDARRIENDODataGridViewTextBoxColumn.HeaderText = "ID_ARRIENDO";
            this.iDARRIENDODataGridViewTextBoxColumn.Name = "iDARRIENDODataGridViewTextBoxColumn";
            // 
            // fECHAINICIODataGridViewTextBoxColumn
            // 
            this.fECHAINICIODataGridViewTextBoxColumn.DataPropertyName = "FECHA_INICIO";
            this.fECHAINICIODataGridViewTextBoxColumn.HeaderText = "FECHA_INICIO";
            this.fECHAINICIODataGridViewTextBoxColumn.Name = "fECHAINICIODataGridViewTextBoxColumn";
            // 
            // fECHATERMINODataGridViewTextBoxColumn
            // 
            this.fECHATERMINODataGridViewTextBoxColumn.DataPropertyName = "FECHA_TERMINO";
            this.fECHATERMINODataGridViewTextBoxColumn.HeaderText = "FECHA_TERMINO";
            this.fECHATERMINODataGridViewTextBoxColumn.Name = "fECHATERMINODataGridViewTextBoxColumn";
            // 
            // aRRENDATARIODataGridViewTextBoxColumn
            // 
            this.aRRENDATARIODataGridViewTextBoxColumn.DataPropertyName = "ARRENDATARIO";
            this.aRRENDATARIODataGridViewTextBoxColumn.HeaderText = "ARRENDATARIO";
            this.aRRENDATARIODataGridViewTextBoxColumn.Name = "aRRENDATARIODataGridViewTextBoxColumn";
            // 
            // tIPOCLIENTEIDTIPODataGridViewTextBoxColumn
            // 
            this.tIPOCLIENTEIDTIPODataGridViewTextBoxColumn.DataPropertyName = "TIPO_CLIENTE_ID_TIPO";
            this.tIPOCLIENTEIDTIPODataGridViewTextBoxColumn.HeaderText = "TIPO_CLIENTE_ID_TIPO";
            this.tIPOCLIENTEIDTIPODataGridViewTextBoxColumn.Name = "tIPOCLIENTEIDTIPODataGridViewTextBoxColumn";
            // 
            // vARRIENDOBindingSource
            // 
            this.vARRIENDOBindingSource.DataMember = "V_ARRIENDO";
            this.vARRIENDOBindingSource.DataSource = this.dataSetV_Arriendo;
            // 
            // dataSetV_Arriendo
            // 
            this.dataSetV_Arriendo.DataSetName = "DataSetV_Arriendo";
            this.dataSetV_Arriendo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // v_ARRIENDOTableAdapter
            // 
            this.v_ARRIENDOTableAdapter.ClearBeforeFill = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(113, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Visor Arriendo";
            // 
            // btn_Arriendo
            // 
            this.btn_Arriendo.Location = new System.Drawing.Point(221, 220);
            this.btn_Arriendo.Name = "btn_Arriendo";
            this.btn_Arriendo.Size = new System.Drawing.Size(118, 23);
            this.btn_Arriendo.TabIndex = 14;
            this.btn_Arriendo.Text = "Actualizar Visor";
            this.btn_Arriendo.UseVisualStyleBackColor = true;
            this.btn_Arriendo.Click += new System.EventHandler(this.btn_Arriendo_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dateTime_Ter);
            this.panel1.Controls.Add(this.dateTime_Ini);
            this.panel1.Controls.Add(this.txt_id_tipo_c);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btn_grabar);
            this.panel1.Location = new System.Drawing.Point(26, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 161);
            this.panel1.TabIndex = 15;
            // 
            // dateTime_Ter
            // 
            this.dateTime_Ter.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTime_Ter.Location = new System.Drawing.Point(145, 41);
            this.dateTime_Ter.Name = "dateTime_Ter";
            this.dateTime_Ter.Size = new System.Drawing.Size(71, 20);
            this.dateTime_Ter.TabIndex = 32;
            // 
            // dateTime_Ini
            // 
            this.dateTime_Ini.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTime_Ini.Location = new System.Drawing.Point(145, 10);
            this.dateTime_Ini.Name = "dateTime_Ini";
            this.dateTime_Ini.Size = new System.Drawing.Size(75, 20);
            this.dateTime_Ini.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(97, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Arriendo de Usuario";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(697, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Mapa";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcionesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1134, 24);
            this.menuStrip1.TabIndex = 29;
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
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(1076, 34);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(39, 13);
            this.label17.TabIndex = 31;
            this.label17.Text = "ZOOM";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(1079, 53);
            this.trackBar1.Maximum = 24;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar1.Size = new System.Drawing.Size(45, 494);
            this.trackBar1.TabIndex = 30;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // btn_zoom_ou
            // 
            this.btn_zoom_ou.Location = new System.Drawing.Point(825, 34);
            this.btn_zoom_ou.Name = "btn_zoom_ou";
            this.btn_zoom_ou.Size = new System.Drawing.Size(75, 23);
            this.btn_zoom_ou.TabIndex = 33;
            this.btn_zoom_ou.Text = "Zoom out";
            this.btn_zoom_ou.UseVisualStyleBackColor = true;
            this.btn_zoom_ou.Click += new System.EventHandler(this.btn_zoom_ou_Click);
            // 
            // btn_zoom_i
            // 
            this.btn_zoom_i.Location = new System.Drawing.Point(938, 34);
            this.btn_zoom_i.Name = "btn_zoom_i";
            this.btn_zoom_i.Size = new System.Drawing.Size(75, 23);
            this.btn_zoom_i.TabIndex = 32;
            this.btn_zoom_i.Text = "Zoom In";
            this.btn_zoom_i.UseVisualStyleBackColor = true;
            this.btn_zoom_i.Click += new System.EventHandler(this.btn_zoom_i_Click);
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(327, 53);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(68, 20);
            this.txt_id.TabIndex = 34;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(262, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 35;
            this.label8.Text = "id_arriendo";
            // 
            // Fr_Arriendo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 573);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.btn_zoom_ou);
            this.Controls.Add(this.btn_zoom_i);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_Arriendo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.gMapControl1);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Fr_Arriendo";
            this.Text = "Administración Arriendo";
            this.Load += new System.EventHandler(this.Fr_Arriendo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vARRIENDOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetV_Arriendo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_grabar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_id_tipo_c;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSetV_Arriendo dataSetV_Arriendo;
        private System.Windows.Forms.BindingSource vARRIENDOBindingSource;
        private DataSetV_ArriendoTableAdapters.V_ARRIENDOTableAdapter v_ARRIENDOTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDARRIENDODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fECHAINICIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fECHATERMINODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aRRENDATARIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tIPOCLIENTEIDTIPODataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Arriendo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem volverAtrasToolStripMenuItem;
        private System.Windows.Forms.DateTimePicker dateTime_Ter;
        private System.Windows.Forms.DateTimePicker dateTime_Ini;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button btn_zoom_ou;
        private System.Windows.Forms.Button btn_zoom_i;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label8;
    }
}