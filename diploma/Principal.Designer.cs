namespace UI
{
    partial class Principal
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
            this.administracionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.permisosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bajaUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambioDePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bitacoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administracionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(617, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // administracionToolStripMenuItem
            // 
            this.administracionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuariosToolStripMenuItem,
            this.permisosToolStripMenuItem,
            this.bitacoraToolStripMenuItem});
            this.administracionToolStripMenuItem.Name = "administracionToolStripMenuItem";
            this.administracionToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.administracionToolStripMenuItem.Text = "Administracion";
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaUsuariosToolStripMenuItem,
            this.bajaUsuariosToolStripMenuItem,
            this.cambioDePasswordToolStripMenuItem});
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            // 
            // permisosToolStripMenuItem
            // 
            this.permisosToolStripMenuItem.Name = "permisosToolStripMenuItem";
            this.permisosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.permisosToolStripMenuItem.Text = "Permisos";
            // 
            // altaUsuariosToolStripMenuItem
            // 
            this.altaUsuariosToolStripMenuItem.Name = "altaUsuariosToolStripMenuItem";
            this.altaUsuariosToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.altaUsuariosToolStripMenuItem.Text = "Alta Usuarios";
            this.altaUsuariosToolStripMenuItem.Click += new System.EventHandler(this.altaUsuariosToolStripMenuItem_Click);
            // 
            // bajaUsuariosToolStripMenuItem
            // 
            this.bajaUsuariosToolStripMenuItem.Name = "bajaUsuariosToolStripMenuItem";
            this.bajaUsuariosToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.bajaUsuariosToolStripMenuItem.Text = "Baja Usuarios";
            this.bajaUsuariosToolStripMenuItem.Click += new System.EventHandler(this.bajaUsuariosToolStripMenuItem_Click);
            // 
            // cambioDePasswordToolStripMenuItem
            // 
            this.cambioDePasswordToolStripMenuItem.Name = "cambioDePasswordToolStripMenuItem";
            this.cambioDePasswordToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.cambioDePasswordToolStripMenuItem.Text = "Cambio de Password";
            this.cambioDePasswordToolStripMenuItem.Click += new System.EventHandler(this.cambioDePasswordToolStripMenuItem_Click);
            // 
            // bitacoraToolStripMenuItem
            // 
            this.bitacoraToolStripMenuItem.Name = "bitacoraToolStripMenuItem";
            this.bitacoraToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.bitacoraToolStripMenuItem.Text = "Bitacora";
            this.bitacoraToolStripMenuItem.Click += new System.EventHandler(this.bitacoraToolStripMenuItem_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(617, 120);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Principal";
            this.Text = "Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem administracionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bajaUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambioDePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem permisosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bitacoraToolStripMenuItem;
    }
}