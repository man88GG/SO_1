namespace Simulacion_Procesos
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.IconMin = new System.Windows.Forms.PictureBox();
            this.IconCerrar = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.TxtActualizar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lst_CPU = new System.Windows.Forms.ListBox();
            this.lst_memoriavirtual = new System.Windows.Forms.ListBox();
            this.lst_memoriafisica = new System.Windows.Forms.ListBox();
            this.lst_id = new System.Windows.Forms.ListBox();
            this.lstProcesses = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconCerrar)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.IconMin);
            this.panel1.Controls.Add(this.IconCerrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1333, 49);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(596, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "ADMINISTRADOR DE PROCESOS GRUPO #4";
            // 
            // IconMin
            // 
            this.IconMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.IconMin.BackColor = System.Drawing.Color.White;
            this.IconMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IconMin.Image = ((System.Drawing.Image)(resources.GetObject("IconMin.Image")));
            this.IconMin.Location = new System.Drawing.Point(1225, 4);
            this.IconMin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.IconMin.Name = "IconMin";
            this.IconMin.Size = new System.Drawing.Size(48, 39);
            this.IconMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.IconMin.TabIndex = 2;
            this.IconMin.TabStop = false;
            this.IconMin.Click += new System.EventHandler(this.IconMin_Click);
            // 
            // IconCerrar
            // 
            this.IconCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.IconCerrar.BackColor = System.Drawing.Color.White;
            this.IconCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IconCerrar.Image = ((System.Drawing.Image)(resources.GetObject("IconCerrar.Image")));
            this.IconCerrar.Location = new System.Drawing.Point(1281, 4);
            this.IconCerrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.IconCerrar.Name = "IconCerrar";
            this.IconCerrar.Size = new System.Drawing.Size(48, 39);
            this.IconCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.IconCerrar.TabIndex = 1;
            this.IconCerrar.TabStop = false;
            this.IconCerrar.Click += new System.EventHandler(this.IconCerrar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.TxtActualizar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 49);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(296, 566);
            this.panel2.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Verdana", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(0, 70);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(296, 74);
            this.button2.TabIndex = 2;
            this.button2.Text = "BORRAR PROCESO";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Verdana", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 151);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(296, 74);
            this.button1.TabIndex = 1;
            this.button1.Text = "OTRA COSA XD";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // TxtActualizar
            // 
            this.TxtActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TxtActualizar.FlatAppearance.BorderSize = 0;
            this.TxtActualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.TxtActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TxtActualizar.Font = new System.Drawing.Font("Verdana", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtActualizar.ForeColor = System.Drawing.Color.Black;
            this.TxtActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TxtActualizar.Location = new System.Drawing.Point(0, 0);
            this.TxtActualizar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtActualizar.Name = "TxtActualizar";
            this.TxtActualizar.Size = new System.Drawing.Size(296, 74);
            this.TxtActualizar.TabIndex = 0;
            this.TxtActualizar.Text = "ACTUALIZAR";
            this.TxtActualizar.UseVisualStyleBackColor = true;
            this.TxtActualizar.Click += new System.EventHandler(this.TxtActualizar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(1192, 73);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 17);
            this.label6.TabIndex = 25;
            this.label6.Text = "CPU:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(943, 73);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 17);
            this.label5.TabIndex = 24;
            this.label5.Text = "Memoria Virtual:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(744, 73);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 17);
            this.label4.TabIndex = 23;
            this.label4.Text = "Memoria fisica :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(573, 73);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 17);
            this.label3.TabIndex = 22;
            this.label3.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(368, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "Procesos:";
            // 
            // lst_CPU
            // 
            this.lst_CPU.FormattingEnabled = true;
            this.lst_CPU.HorizontalScrollbar = true;
            this.lst_CPU.ItemHeight = 16;
            this.lst_CPU.Location = new System.Drawing.Point(1131, 100);
            this.lst_CPU.Margin = new System.Windows.Forms.Padding(4);
            this.lst_CPU.Name = "lst_CPU";
            this.lst_CPU.ScrollAlwaysVisible = true;
            this.lst_CPU.Size = new System.Drawing.Size(155, 404);
            this.lst_CPU.TabIndex = 20;
            // 
            // lst_memoriavirtual
            // 
            this.lst_memoriavirtual.FormattingEnabled = true;
            this.lst_memoriavirtual.HorizontalScrollbar = true;
            this.lst_memoriavirtual.ItemHeight = 16;
            this.lst_memoriavirtual.Location = new System.Drawing.Point(920, 100);
            this.lst_memoriavirtual.Margin = new System.Windows.Forms.Padding(4);
            this.lst_memoriavirtual.Name = "lst_memoriavirtual";
            this.lst_memoriavirtual.ScrollAlwaysVisible = true;
            this.lst_memoriavirtual.Size = new System.Drawing.Size(155, 404);
            this.lst_memoriavirtual.TabIndex = 19;
            // 
            // lst_memoriafisica
            // 
            this.lst_memoriafisica.FormattingEnabled = true;
            this.lst_memoriafisica.HorizontalScrollbar = true;
            this.lst_memoriafisica.ItemHeight = 16;
            this.lst_memoriafisica.Location = new System.Drawing.Point(720, 100);
            this.lst_memoriafisica.Margin = new System.Windows.Forms.Padding(4);
            this.lst_memoriafisica.Name = "lst_memoriafisica";
            this.lst_memoriafisica.ScrollAlwaysVisible = true;
            this.lst_memoriafisica.Size = new System.Drawing.Size(155, 404);
            this.lst_memoriafisica.TabIndex = 18;
            // 
            // lst_id
            // 
            this.lst_id.FormattingEnabled = true;
            this.lst_id.HorizontalScrollbar = true;
            this.lst_id.ItemHeight = 16;
            this.lst_id.Location = new System.Drawing.Point(513, 100);
            this.lst_id.Margin = new System.Windows.Forms.Padding(4);
            this.lst_id.Name = "lst_id";
            this.lst_id.ScrollAlwaysVisible = true;
            this.lst_id.Size = new System.Drawing.Size(155, 404);
            this.lst_id.TabIndex = 17;
            // 
            // lstProcesses
            // 
            this.lstProcesses.FormattingEnabled = true;
            this.lstProcesses.HorizontalScrollbar = true;
            this.lstProcesses.ItemHeight = 16;
            this.lstProcesses.Location = new System.Drawing.Point(327, 100);
            this.lstProcesses.Margin = new System.Windows.Forms.Padding(4);
            this.lstProcesses.Name = "lstProcesses";
            this.lstProcesses.ScrollAlwaysVisible = true;
            this.lstProcesses.Size = new System.Drawing.Size(155, 404);
            this.lstProcesses.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1333, 615);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lst_CPU);
            this.Controls.Add(this.lst_memoriavirtual);
            this.Controls.Add(this.lst_memoriafisica);
            this.Controls.Add(this.lst_id);
            this.Controls.Add(this.lstProcesses);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconCerrar)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox IconMin;
        private System.Windows.Forms.PictureBox IconCerrar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button TxtActualizar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lst_CPU;
        private System.Windows.Forms.ListBox lst_memoriavirtual;
        private System.Windows.Forms.ListBox lst_memoriafisica;
        private System.Windows.Forms.ListBox lst_id;
        private System.Windows.Forms.ListBox lstProcesses;
    }
}

