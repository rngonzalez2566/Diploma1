namespace UI
{
    partial class Bitacora
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dpd = new System.Windows.Forms.DateTimePicker();
            this.dph = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbUsuario = new System.Windows.Forms.ComboBox();
            this.cmbCriticidad = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ftfecha = new System.Windows.Forms.CheckBox();
            this.ftUsuario = new System.Windows.Forms.CheckBox();
            this.ftCriticidad = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(21, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha Desde";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(21, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha Hasta";
            // 
            // dpd
            // 
            this.dpd.Location = new System.Drawing.Point(160, 83);
            this.dpd.Name = "dpd";
            this.dpd.Size = new System.Drawing.Size(200, 20);
            this.dpd.TabIndex = 2;
            // 
            // dph
            // 
            this.dph.Location = new System.Drawing.Point(160, 131);
            this.dph.Name = "dph";
            this.dph.Size = new System.Drawing.Size(200, 20);
            this.dph.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(21, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Usuario";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(387, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Criticidad";
            // 
            // cmbUsuario
            // 
            this.cmbUsuario.FormattingEnabled = true;
            this.cmbUsuario.Location = new System.Drawing.Point(111, 180);
            this.cmbUsuario.Name = "cmbUsuario";
            this.cmbUsuario.Size = new System.Drawing.Size(121, 21);
            this.cmbUsuario.TabIndex = 6;
            // 
            // cmbCriticidad
            // 
            this.cmbCriticidad.FormattingEnabled = true;
            this.cmbCriticidad.Location = new System.Drawing.Point(499, 83);
            this.cmbCriticidad.Name = "cmbCriticidad";
            this.cmbCriticidad.Size = new System.Drawing.Size(84, 21);
            this.cmbCriticidad.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 269);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(562, 384);
            this.dataGridView1.TabIndex = 8;
            // 
            // ftfecha
            // 
            this.ftfecha.AutoSize = true;
            this.ftfecha.ForeColor = System.Drawing.Color.Red;
            this.ftfecha.Location = new System.Drawing.Point(54, 228);
            this.ftfecha.Name = "ftfecha";
            this.ftfecha.Size = new System.Drawing.Size(99, 17);
            this.ftfecha.TabIndex = 10;
            this.ftfecha.Text = "Filtro por Fecha";
            this.ftfecha.UseVisualStyleBackColor = true;
            // 
            // ftUsuario
            // 
            this.ftUsuario.AutoSize = true;
            this.ftUsuario.ForeColor = System.Drawing.Color.Red;
            this.ftUsuario.Location = new System.Drawing.Point(179, 228);
            this.ftUsuario.Name = "ftUsuario";
            this.ftUsuario.Size = new System.Drawing.Size(105, 17);
            this.ftUsuario.TabIndex = 11;
            this.ftUsuario.Text = "Filtro por Usuario";
            this.ftUsuario.UseVisualStyleBackColor = true;
            // 
            // ftCriticidad
            // 
            this.ftCriticidad.AutoSize = true;
            this.ftCriticidad.ForeColor = System.Drawing.Color.Red;
            this.ftCriticidad.Location = new System.Drawing.Point(311, 228);
            this.ftCriticidad.Name = "ftCriticidad";
            this.ftCriticidad.Size = new System.Drawing.Size(112, 17);
            this.ftCriticidad.TabIndex = 12;
            this.ftCriticidad.Text = "Filtro por Criticidad";
            this.ftCriticidad.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Handwriting", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(216, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 36);
            this.label5.TabIndex = 13;
            this.label5.Text = "Bitacora";
            // 
            // button1
            // 
            this.button1.Image = global::UI.Properties.Resources.loupe_78347;
            this.button1.Location = new System.Drawing.Point(420, 149);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 73);
            this.button1.TabIndex = 9;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Bitacora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(598, 665);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ftCriticidad);
            this.Controls.Add(this.ftUsuario);
            this.Controls.Add(this.ftfecha);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmbCriticidad);
            this.Controls.Add(this.cmbUsuario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dph);
            this.Controls.Add(this.dpd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Bitacora";
            this.Text = "Bitacora";
            this.Load += new System.EventHandler(this.Bitacora_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dpd;
        private System.Windows.Forms.DateTimePicker dph;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbUsuario;
        private System.Windows.Forms.ComboBox cmbCriticidad;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox ftfecha;
        private System.Windows.Forms.CheckBox ftUsuario;
        private System.Windows.Forms.CheckBox ftCriticidad;
        private System.Windows.Forms.Label label5;
    }
}