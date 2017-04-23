namespace Proyecto_estacionamiento
{
    partial class Fr_estacionamiento
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
            this.Btn_Guardar = new System.Windows.Forms.Button();
            this.txt_Direccion = new System.Windows.Forms.TextBox();
            this.txt_latitud = new System.Windows.Forms.TextBox();
            this.txt_longitud = new System.Windows.Forms.TextBox();
            this.Btn_Buscar = new System.Windows.Forms.Button();
            this.Btn_Actualizar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboComuna = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_precio = new System.Windows.Forms.TextBox();
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.volverAtrasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formularioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoEstacionamientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_zoom_ou = new System.Windows.Forms.Button();
            this.btn_zoom_i = new System.Windows.Forms.Button();
            this.txt_buscar_direccion = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_id_mo = new System.Windows.Forms.TextBox();
            this.dateTime_Ter = new System.Windows.Forms.DateTimePicker();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.dateTime_Ini = new System.Windows.Forms.DateTimePicker();
            this.txt_Dispo = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_id_tipo = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dataSet3 = new Proyecto_estacionamiento.DataSet3();
            this.vESTACIONAMIENTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.v_ESTACIONAMIENTOTableAdapter = new Proyecto_estacionamiento.DataSet3TableAdapters.V_ESTACIONAMIENTOTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDESTACIONAMIENTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dIRECCIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOMUNADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lATITUDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lONGITUDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRECIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aRRENDADORDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tIPOCLIENTEIDTIPODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dISPONIBILIDADDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hORARIOINICIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hORARIOTERMINODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label12 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label17 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vESTACIONAMIENTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Guardar
            // 
            this.Btn_Guardar.Location = new System.Drawing.Point(9, 228);
            this.Btn_Guardar.Name = "Btn_Guardar";
            this.Btn_Guardar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Guardar.TabIndex = 0;
            this.Btn_Guardar.Text = "Guardar";
            this.Btn_Guardar.UseVisualStyleBackColor = true;
            this.Btn_Guardar.Click += new System.EventHandler(this.Btn_Guardar_Click);
            // 
            // txt_Direccion
            // 
            this.txt_Direccion.Location = new System.Drawing.Point(85, 19);
            this.txt_Direccion.Name = "txt_Direccion";
            this.txt_Direccion.Size = new System.Drawing.Size(100, 20);
            this.txt_Direccion.TabIndex = 6;
            // 
            // txt_latitud
            // 
            this.txt_latitud.Location = new System.Drawing.Point(85, 81);
            this.txt_latitud.Name = "txt_latitud";
            this.txt_latitud.Size = new System.Drawing.Size(100, 20);
            this.txt_latitud.TabIndex = 7;
            // 
            // txt_longitud
            // 
            this.txt_longitud.Location = new System.Drawing.Point(85, 113);
            this.txt_longitud.Name = "txt_longitud";
            this.txt_longitud.Size = new System.Drawing.Size(100, 20);
            this.txt_longitud.TabIndex = 8;
            // 
            // Btn_Buscar
            // 
            this.Btn_Buscar.Location = new System.Drawing.Point(234, 22);
            this.Btn_Buscar.Name = "Btn_Buscar";
            this.Btn_Buscar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Buscar.TabIndex = 9;
            this.Btn_Buscar.Text = "Buscar";
            this.Btn_Buscar.UseVisualStyleBackColor = true;
            this.Btn_Buscar.Click += new System.EventHandler(this.Btn_Buscar_Click);
            // 
            // Btn_Actualizar
            // 
            this.Btn_Actualizar.Location = new System.Drawing.Point(110, 228);
            this.Btn_Actualizar.Name = "Btn_Actualizar";
            this.Btn_Actualizar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Actualizar.TabIndex = 10;
            this.Btn_Actualizar.Text = "Modificar";
            this.Btn_Actualizar.UseVisualStyleBackColor = true;
            this.Btn_Actualizar.Click += new System.EventHandler(this.Btn_Actualizar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Dirección";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Comuna";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Latitud";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Longitud";
            // 
            // comboComuna
            // 
            this.comboComuna.FormattingEnabled = true;
            this.comboComuna.Items.AddRange(new object[] {
            "Cerrillos",
            "Cerro Navia",
            "Conchalí",
            "El Bosque",
            "Estación Central",
            "Huechuraba",
            "Independencia",
            "La Cisterna",
            "La Florida",
            "La Granja",
            "La Pintana",
            "La Reina",
            "Las Condes",
            "Lo Barnechea",
            "Lo Espejo",
            "Lo Prado",
            "Macul",
            "Maipú",
            "Ñuñoa",
            "Padre Hurtado",
            "Pedro Aguirre Cerda",
            "Peñalolén",
            "Pirque",
            "Providencia",
            "Pudahuel",
            "Puente Alto",
            "Quilicura",
            "Quinta Normal",
            "Recoleta",
            "Renca",
            "San Bernardo",
            "San Joaquín",
            "San José de Maipo",
            "San Miguel",
            "San Ramón",
            "Santiago",
            "Vitacura"});
            this.comboComuna.Location = new System.Drawing.Point(85, 48);
            this.comboComuna.Name = "comboComuna";
            this.comboComuna.Size = new System.Drawing.Size(115, 21);
            this.comboComuna.TabIndex = 17;
            this.comboComuna.Text = "Seleccione comuna";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Precio";
            // 
            // txt_precio
            // 
            this.txt_precio.Location = new System.Drawing.Point(85, 149);
            this.txt_precio.Name = "txt_precio";
            this.txt_precio.Size = new System.Drawing.Size(100, 20);
            this.txt_precio.TabIndex = 19;
            // 
            // gMapControl1
            // 
            this.gMapControl1.Bearing = 0F;
            this.gMapControl1.CanDragMap = true;
            this.gMapControl1.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl1.GrayScaleMode = false;
            this.gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl1.LevelsKeepInMemmory = 5;
            this.gMapControl1.Location = new System.Drawing.Point(418, 91);
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
            this.gMapControl1.Size = new System.Drawing.Size(528, 449);
            this.gMapControl1.TabIndex = 20;
            this.gMapControl1.Zoom = 0D;
            this.gMapControl1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseM);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcionesToolStripMenuItem,
            this.formularioToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1019, 24);
            this.menuStrip1.TabIndex = 21;
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
            this.volverAtrasToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.volverAtrasToolStripMenuItem.Text = "Volver atras";
            this.volverAtrasToolStripMenuItem.Click += new System.EventHandler(this.volverAtrasToolStripMenuItem_Click);
            // 
            // formularioToolStripMenuItem
            // 
            this.formularioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listadoEstacionamientoToolStripMenuItem});
            this.formularioToolStripMenuItem.Name = "formularioToolStripMenuItem";
            this.formularioToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.formularioToolStripMenuItem.Text = "Formulario ";
            // 
            // listadoEstacionamientoToolStripMenuItem
            // 
            this.listadoEstacionamientoToolStripMenuItem.Name = "listadoEstacionamientoToolStripMenuItem";
            this.listadoEstacionamientoToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.listadoEstacionamientoToolStripMenuItem.Text = "Listado Estacionamiento";
            this.listadoEstacionamientoToolStripMenuItem.Click += new System.EventHandler(this.listadoEstacionamientoToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_zoom_ou);
            this.panel1.Controls.Add(this.btn_zoom_i);
            this.panel1.Controls.Add(this.txt_buscar_direccion);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.Btn_Buscar);
            this.panel1.Location = new System.Drawing.Point(418, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(517, 48);
            this.panel1.TabIndex = 22;
            // 
            // btn_zoom_ou
            // 
            this.btn_zoom_ou.Location = new System.Drawing.Point(327, 22);
            this.btn_zoom_ou.Name = "btn_zoom_ou";
            this.btn_zoom_ou.Size = new System.Drawing.Size(75, 23);
            this.btn_zoom_ou.TabIndex = 25;
            this.btn_zoom_ou.Text = "Zoom out";
            this.btn_zoom_ou.UseVisualStyleBackColor = true;
            this.btn_zoom_ou.Click += new System.EventHandler(this.btn_zoom_ou_Click);
            // 
            // btn_zoom_i
            // 
            this.btn_zoom_i.Location = new System.Drawing.Point(420, 21);
            this.btn_zoom_i.Name = "btn_zoom_i";
            this.btn_zoom_i.Size = new System.Drawing.Size(75, 23);
            this.btn_zoom_i.TabIndex = 23;
            this.btn_zoom_i.Text = "Zoom In";
            this.btn_zoom_i.UseVisualStyleBackColor = true;
            this.btn_zoom_i.Click += new System.EventHandler(this.btn_zoom_i_Click);
            // 
            // txt_buscar_direccion
            // 
            this.txt_buscar_direccion.Location = new System.Drawing.Point(106, 24);
            this.txt_buscar_direccion.Name = "txt_buscar_direccion";
            this.txt_buscar_direccion.Size = new System.Drawing.Size(100, 20);
            this.txt_buscar_direccion.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Dirección a buscar";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(520, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Mostrar Dirección en el mapa";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txt_id_mo);
            this.panel2.Controls.Add(this.dateTime_Ter);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.dateTime_Ini);
            this.panel2.Controls.Add(this.txt_Dispo);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.txt_id_tipo);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.Btn_Actualizar);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txt_Direccion);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.comboComuna);
            this.panel2.Controls.Add(this.txt_precio);
            this.panel2.Controls.Add(this.Btn_Guardar);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txt_latitud);
            this.panel2.Controls.Add(this.txt_longitud);
            this.panel2.Location = new System.Drawing.Point(23, 37);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(389, 267);
            this.panel2.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(216, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Id modificar";
            // 
            // txt_id_mo
            // 
            this.txt_id_mo.Location = new System.Drawing.Point(283, 126);
            this.txt_id_mo.Name = "txt_id_mo";
            this.txt_id_mo.Size = new System.Drawing.Size(100, 20);
            this.txt_id_mo.TabIndex = 31;
            // 
            // dateTime_Ter
            // 
            this.dateTime_Ter.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTime_Ter.Location = new System.Drawing.Point(307, 82);
            this.dateTime_Ter.Name = "dateTime_Ter";
            this.dateTime_Ter.Size = new System.Drawing.Size(71, 20);
            this.dateTime_Ter.TabIndex = 30;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(208, 88);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(85, 13);
            this.label16.TabIndex = 29;
            this.label16.Text = "Horario_Termino";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(208, 54);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(69, 13);
            this.label15.TabIndex = 28;
            this.label15.Text = "Horario Inicio";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(212, 19);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(72, 13);
            this.label14.TabIndex = 27;
            this.label14.Text = "Disponibilidad";
            // 
            // dateTime_Ini
            // 
            this.dateTime_Ini.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTime_Ini.Location = new System.Drawing.Point(307, 51);
            this.dateTime_Ini.Name = "dateTime_Ini";
            this.dateTime_Ini.Size = new System.Drawing.Size(75, 20);
            this.dateTime_Ini.TabIndex = 26;
            // 
            // txt_Dispo
            // 
            this.txt_Dispo.Location = new System.Drawing.Point(283, 15);
            this.txt_Dispo.Name = "txt_Dispo";
            this.txt_Dispo.Size = new System.Drawing.Size(100, 20);
            this.txt_Dispo.TabIndex = 25;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 181);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(81, 13);
            this.label13.TabIndex = 22;
            this.label13.Text = "Id_Tipo_Cliente";
            // 
            // txt_id_tipo
            // 
            this.txt_id_tipo.Location = new System.Drawing.Point(125, 175);
            this.txt_id_tipo.Name = "txt_id_tipo";
            this.txt_id_tipo.Size = new System.Drawing.Size(60, 20);
            this.txt_id_tipo.TabIndex = 21;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.btn_Eliminar);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.txt_id);
            this.panel3.Location = new System.Drawing.Point(231, 179);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(158, 85);
            this.panel3.TabIndex = 24;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(132, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "Estacionamiento a eliminar";
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Location = new System.Drawing.Point(52, 59);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(75, 23);
            this.btn_Eliminar.TabIndex = 2;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Id Eliminar";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(76, 23);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(76, 20);
            this.txt_id.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, -1);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(133, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Datos del Estacionamiento";
            // 
            // dataSet3
            // 
            this.dataSet3.DataSetName = "DataSet3";
            this.dataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vESTACIONAMIENTOBindingSource
            // 
            this.vESTACIONAMIENTOBindingSource.DataMember = "V_ESTACIONAMIENTO";
            this.vESTACIONAMIENTOBindingSource.DataSource = this.dataSet3;
            // 
            // v_ESTACIONAMIENTOTableAdapter
            // 
            this.v_ESTACIONAMIENTOTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDESTACIONAMIENTODataGridViewTextBoxColumn,
            this.dIRECCIONDataGridViewTextBoxColumn,
            this.cOMUNADataGridViewTextBoxColumn,
            this.lATITUDDataGridViewTextBoxColumn,
            this.lONGITUDDataGridViewTextBoxColumn,
            this.pRECIODataGridViewTextBoxColumn,
            this.aRRENDADORDataGridViewTextBoxColumn,
            this.tIPOCLIENTEIDTIPODataGridViewTextBoxColumn,
            this.dISPONIBILIDADDataGridViewTextBoxColumn,
            this.hORARIOINICIODataGridViewTextBoxColumn,
            this.hORARIOTERMINODataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.vESTACIONAMIENTOBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(29, 390);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(352, 160);
            this.dataGridView1.TabIndex = 25;
            // 
            // iDESTACIONAMIENTODataGridViewTextBoxColumn
            // 
            this.iDESTACIONAMIENTODataGridViewTextBoxColumn.DataPropertyName = "ID_ESTACIONAMIENTO";
            this.iDESTACIONAMIENTODataGridViewTextBoxColumn.HeaderText = "ID_ESTACIONAMIENTO";
            this.iDESTACIONAMIENTODataGridViewTextBoxColumn.Name = "iDESTACIONAMIENTODataGridViewTextBoxColumn";
            // 
            // dIRECCIONDataGridViewTextBoxColumn
            // 
            this.dIRECCIONDataGridViewTextBoxColumn.DataPropertyName = "DIRECCION";
            this.dIRECCIONDataGridViewTextBoxColumn.HeaderText = "DIRECCION";
            this.dIRECCIONDataGridViewTextBoxColumn.Name = "dIRECCIONDataGridViewTextBoxColumn";
            // 
            // cOMUNADataGridViewTextBoxColumn
            // 
            this.cOMUNADataGridViewTextBoxColumn.DataPropertyName = "COMUNA";
            this.cOMUNADataGridViewTextBoxColumn.HeaderText = "COMUNA";
            this.cOMUNADataGridViewTextBoxColumn.Name = "cOMUNADataGridViewTextBoxColumn";
            // 
            // lATITUDDataGridViewTextBoxColumn
            // 
            this.lATITUDDataGridViewTextBoxColumn.DataPropertyName = "LATITUD";
            this.lATITUDDataGridViewTextBoxColumn.HeaderText = "LATITUD";
            this.lATITUDDataGridViewTextBoxColumn.Name = "lATITUDDataGridViewTextBoxColumn";
            // 
            // lONGITUDDataGridViewTextBoxColumn
            // 
            this.lONGITUDDataGridViewTextBoxColumn.DataPropertyName = "LONGITUD";
            this.lONGITUDDataGridViewTextBoxColumn.HeaderText = "LONGITUD";
            this.lONGITUDDataGridViewTextBoxColumn.Name = "lONGITUDDataGridViewTextBoxColumn";
            // 
            // pRECIODataGridViewTextBoxColumn
            // 
            this.pRECIODataGridViewTextBoxColumn.DataPropertyName = "PRECIO";
            this.pRECIODataGridViewTextBoxColumn.HeaderText = "PRECIO";
            this.pRECIODataGridViewTextBoxColumn.Name = "pRECIODataGridViewTextBoxColumn";
            // 
            // aRRENDADORDataGridViewTextBoxColumn
            // 
            this.aRRENDADORDataGridViewTextBoxColumn.DataPropertyName = "ARRENDADOR";
            this.aRRENDADORDataGridViewTextBoxColumn.HeaderText = "ARRENDADOR";
            this.aRRENDADORDataGridViewTextBoxColumn.Name = "aRRENDADORDataGridViewTextBoxColumn";
            // 
            // tIPOCLIENTEIDTIPODataGridViewTextBoxColumn
            // 
            this.tIPOCLIENTEIDTIPODataGridViewTextBoxColumn.DataPropertyName = "TIPO_CLIENTE_ID_TIPO";
            this.tIPOCLIENTEIDTIPODataGridViewTextBoxColumn.HeaderText = "TIPO_CLIENTE_ID_TIPO";
            this.tIPOCLIENTEIDTIPODataGridViewTextBoxColumn.Name = "tIPOCLIENTEIDTIPODataGridViewTextBoxColumn";
            // 
            // dISPONIBILIDADDataGridViewTextBoxColumn
            // 
            this.dISPONIBILIDADDataGridViewTextBoxColumn.DataPropertyName = "DISPONIBILIDAD";
            this.dISPONIBILIDADDataGridViewTextBoxColumn.HeaderText = "DISPONIBILIDAD";
            this.dISPONIBILIDADDataGridViewTextBoxColumn.Name = "dISPONIBILIDADDataGridViewTextBoxColumn";
            // 
            // hORARIOINICIODataGridViewTextBoxColumn
            // 
            this.hORARIOINICIODataGridViewTextBoxColumn.DataPropertyName = "HORARIO_INICIO";
            this.hORARIOINICIODataGridViewTextBoxColumn.HeaderText = "HORARIO_INICIO";
            this.hORARIOINICIODataGridViewTextBoxColumn.Name = "hORARIOINICIODataGridViewTextBoxColumn";
            // 
            // hORARIOTERMINODataGridViewTextBoxColumn
            // 
            this.hORARIOTERMINODataGridViewTextBoxColumn.DataPropertyName = "HORARIO_TERMINO";
            this.hORARIOTERMINODataGridViewTextBoxColumn.HeaderText = "HORARIO_TERMINO";
            this.hORARIOTERMINODataGridViewTextBoxColumn.Name = "hORARIOTERMINODataGridViewTextBoxColumn";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(130, 363);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(114, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "Visor  Estacionamiento";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(962, 85);
            this.trackBar1.Maximum = 24;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar1.Size = new System.Drawing.Size(45, 465);
            this.trackBar1.TabIndex = 27;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(962, 68);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(39, 13);
            this.label17.TabIndex = 28;
            this.label17.Text = "ZOOM";
            this.label17.Click += new System.EventHandler(this.label17_Click);
            // 
            // Fr_estacionamiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 562);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gMapControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Fr_estacionamiento";
            this.Text = "Administración  de  Estacionamientos";
            this.Load += new System.EventHandler(this.Fr_estacionamiento_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vESTACIONAMIENTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Guardar;
        private System.Windows.Forms.TextBox txt_Direccion;
        private System.Windows.Forms.TextBox txt_latitud;
        private System.Windows.Forms.TextBox txt_longitud;
        private System.Windows.Forms.Button Btn_Buscar;
        private System.Windows.Forms.Button Btn_Actualizar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboComuna;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_precio;
        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem volverAtrasToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_buscar_direccion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_zoom_i;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Label label11;
        private DataSet3 dataSet3;
        private System.Windows.Forms.BindingSource vESTACIONAMIENTOBindingSource;
        private DataSet3TableAdapters.V_ESTACIONAMIENTOTableAdapter v_ESTACIONAMIENTOTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDESTACIONAMIENTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dIRECCIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cOMUNADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lATITUDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lONGITUDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRECIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aRRENDADORDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tIPOCLIENTEIDTIPODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dISPONIBILIDADDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hORARIOINICIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hORARIOTERMINODataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_id_tipo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dateTime_Ini;
        private System.Windows.Forms.TextBox txt_Dispo;
        private System.Windows.Forms.DateTimePicker dateTime_Ter;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btn_zoom_ou;
        private System.Windows.Forms.ToolStripMenuItem formularioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoEstacionamientoToolStripMenuItem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_id_mo;

    }
}