namespace Proyecto_estacionamiento
{
    partial class Fr_Menu_administracion
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.administraciónUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administraciónEstacionamientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administraciónArriendoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.panelDeAdministraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administraciónUsuariosToolStripMenuItem,
            this.administraciónEstacionamientoToolStripMenuItem,
            this.administraciónArriendoToolStripMenuItem,
            this.reportesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(597, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // administraciónUsuariosToolStripMenuItem
            // 
            this.administraciónUsuariosToolStripMenuItem.Name = "administraciónUsuariosToolStripMenuItem";
            this.administraciónUsuariosToolStripMenuItem.Size = new System.Drawing.Size(148, 20);
            this.administraciónUsuariosToolStripMenuItem.Text = "Administración Usuarios";
            this.administraciónUsuariosToolStripMenuItem.Click += new System.EventHandler(this.administraciónUsuariosToolStripMenuItem_Click);
            // 
            // administraciónEstacionamientoToolStripMenuItem
            // 
            this.administraciónEstacionamientoToolStripMenuItem.Name = "administraciónEstacionamientoToolStripMenuItem";
            this.administraciónEstacionamientoToolStripMenuItem.Size = new System.Drawing.Size(191, 20);
            this.administraciónEstacionamientoToolStripMenuItem.Text = "Administración Estacionamiento";
            this.administraciónEstacionamientoToolStripMenuItem.Click += new System.EventHandler(this.administraciónEstacionamientoToolStripMenuItem_Click);
            // 
            // administraciónArriendoToolStripMenuItem
            // 
            this.administraciónArriendoToolStripMenuItem.Name = "administraciónArriendoToolStripMenuItem";
            this.administraciónArriendoToolStripMenuItem.Size = new System.Drawing.Size(149, 20);
            this.administraciónArriendoToolStripMenuItem.Text = "Administración Arriendo";
            this.administraciónArriendoToolStripMenuItem.Click += new System.EventHandler(this.administraciónArriendoToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            this.reportesToolStripMenuItem.Click += new System.EventHandler(this.reportesToolStripMenuItem_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.panelDeAdministraciónToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(597, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // panelDeAdministraciónToolStripMenuItem
            // 
            this.panelDeAdministraciónToolStripMenuItem.Name = "panelDeAdministraciónToolStripMenuItem";
            this.panelDeAdministraciónToolStripMenuItem.Size = new System.Drawing.Size(148, 20);
            this.panelDeAdministraciónToolStripMenuItem.Text = "Panel de Administración";
            // 
            // Fr_Menu_administracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proyecto_estacionamiento.Properties.Resources.Captura3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(597, 284);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Fr_Menu_administracion";
            this.Text = "Menu_administracion";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem administraciónUsuariosToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem panelDeAdministraciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administraciónEstacionamientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administraciónArriendoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
    }
}