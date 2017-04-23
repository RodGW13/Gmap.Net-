namespace Proyecto_estacionamiento
{
    partial class Fr_mapa_google
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btn_coordenadas = new System.Windows.Forms.Button();
            this.txt_longitud = new System.Windows.Forms.TextBox();
            this.txt_latitud = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_Ciudad = new System.Windows.Forms.TextBox();
            this.Txt_Direccion = new System.Windows.Forms.TextBox();
            this.Buscar = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTxt_url = new System.Windows.Forms.ToolStripTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.toolStrip1);
            this.splitContainer1.Panel1.Controls.Add(this.btn_coordenadas);
            this.splitContainer1.Panel1.Controls.Add(this.txt_longitud);
            this.splitContainer1.Panel1.Controls.Add(this.txt_latitud);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.Txt_Ciudad);
            this.splitContainer1.Panel1.Controls.Add(this.Txt_Direccion);
            this.splitContainer1.Panel1.Controls.Add(this.Buscar);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.webBrowser1);
            this.splitContainer1.Size = new System.Drawing.Size(912, 409);
            this.splitContainer1.SplitterDistance = 304;
            this.splitContainer1.TabIndex = 0;
            // 
            // btn_coordenadas
            // 
            this.btn_coordenadas.Location = new System.Drawing.Point(97, 331);
            this.btn_coordenadas.Name = "btn_coordenadas";
            this.btn_coordenadas.Size = new System.Drawing.Size(75, 23);
            this.btn_coordenadas.TabIndex = 9;
            this.btn_coordenadas.Text = "Obtener Coordenadas";
            this.btn_coordenadas.UseVisualStyleBackColor = true;
            this.btn_coordenadas.Click += new System.EventHandler(this.btn_coordenadas_Click);
            // 
            // txt_longitud
            // 
            this.txt_longitud.Location = new System.Drawing.Point(115, 272);
            this.txt_longitud.Name = "txt_longitud";
            this.txt_longitud.Size = new System.Drawing.Size(100, 20);
            this.txt_longitud.TabIndex = 1;
            // 
            // txt_latitud
            // 
            this.txt_latitud.Location = new System.Drawing.Point(115, 236);
            this.txt_latitud.Name = "txt_latitud";
            this.txt_latitud.Size = new System.Drawing.Size(100, 20);
            this.txt_latitud.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Longitud";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Latitud ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ciudad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Dirección";
            // 
            // Txt_Ciudad
            // 
            this.Txt_Ciudad.Location = new System.Drawing.Point(126, 91);
            this.Txt_Ciudad.Name = "Txt_Ciudad";
            this.Txt_Ciudad.Size = new System.Drawing.Size(100, 20);
            this.Txt_Ciudad.TabIndex = 3;
            // 
            // Txt_Direccion
            // 
            this.Txt_Direccion.Location = new System.Drawing.Point(126, 46);
            this.Txt_Direccion.Name = "Txt_Direccion";
            this.Txt_Direccion.Size = new System.Drawing.Size(100, 20);
            this.Txt_Direccion.TabIndex = 2;
            // 
            // Buscar
            // 
            this.Buscar.Location = new System.Drawing.Point(62, 149);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(75, 23);
            this.Buscar.TabIndex = 0;
            this.Buscar.Text = "Buscar";
            this.Buscar.UseVisualStyleBackColor = true;
            this.Buscar.Click += new System.EventHandler(this.Buscar_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(604, 409);
            this.webBrowser1.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripTxt_url});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(304, 25);
            this.toolStrip1.TabIndex = 12;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(22, 22);
            this.toolStripLabel1.Text = "Url";
            // 
            // toolStripTxt_url
            // 
            this.toolStripTxt_url.Name = "toolStripTxt_url";
            this.toolStripTxt_url.Size = new System.Drawing.Size(200, 25);
            // 
            // Fr_mapa_google
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 409);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Fr_mapa_google";
            this.Text = "Fr_mapa_google";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button Buscar;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_Ciudad;
        private System.Windows.Forms.TextBox Txt_Direccion;
        private System.Windows.Forms.TextBox txt_longitud;
        private System.Windows.Forms.TextBox txt_latitud;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_coordenadas;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox toolStripTxt_url;

    }
}