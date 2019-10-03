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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.IconMin = new System.Windows.Forms.PictureBox();
            this.IconCerrar = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Btn_Detener = new System.Windows.Forms.Button();
            this.BtnActualizar = new System.Windows.Forms.Button();
            this.lbl_Contador = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dgv_Proceso = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconCerrar)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Proceso)).BeginInit();
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
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
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
            this.IconMin.Margin = new System.Windows.Forms.Padding(4);
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
            this.IconCerrar.Margin = new System.Windows.Forms.Padding(4);
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
            this.panel2.Controls.Add(this.Btn_Detener);
            this.panel2.Controls.Add(this.BtnActualizar);
            this.panel2.Controls.Add(this.lbl_Contador);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 49);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(296, 566);
            this.panel2.TabIndex = 1;
            // 
            // Btn_Detener
            // 
            this.Btn_Detener.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Detener.FlatAppearance.BorderSize = 0;
            this.Btn_Detener.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.Btn_Detener.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Detener.Font = new System.Drawing.Font("Verdana", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Detener.ForeColor = System.Drawing.Color.Black;
            this.Btn_Detener.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Detener.Location = new System.Drawing.Point(19, 161);
            this.Btn_Detener.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Detener.Name = "Btn_Detener";
            this.Btn_Detener.Size = new System.Drawing.Size(273, 74);
            this.Btn_Detener.TabIndex = 8;
            this.Btn_Detener.Text = "Detener Proceso";
            this.Btn_Detener.UseVisualStyleBackColor = true;
            this.Btn_Detener.Click += new System.EventHandler(this.Btn_Detener_Click);
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnActualizar.FlatAppearance.BorderSize = 0;
            this.BtnActualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.BtnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnActualizar.Font = new System.Drawing.Font("Verdana", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnActualizar.ForeColor = System.Drawing.Color.Black;
            this.BtnActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnActualizar.Location = new System.Drawing.Point(13, 79);
            this.BtnActualizar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(271, 74);
            this.BtnActualizar.TabIndex = 6;
            this.BtnActualizar.Text = "Actualizar Tabla";
            this.BtnActualizar.UseVisualStyleBackColor = true;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // lbl_Contador
            // 
            this.lbl_Contador.AutoSize = true;
            this.lbl_Contador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_Contador.Font = new System.Drawing.Font("Verdana", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Contador.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_Contador.Location = new System.Drawing.Point(10, 538);
            this.lbl_Contador.Name = "lbl_Contador";
            this.lbl_Contador.Size = new System.Drawing.Size(155, 17);
            this.lbl_Contador.TabIndex = 5;
            this.lbl_Contador.Text = "Contador Procesos";
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
            this.button1.Location = new System.Drawing.Point(11, 243);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(273, 74);
            this.button1.TabIndex = 1;
            this.button1.Text = "OTRA COSA XD";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 30000;
            // 
            // dgv_Proceso
            // 
            this.dgv_Proceso.AllowUserToAddRows = false;
            this.dgv_Proceso.AllowUserToDeleteRows = false;
            this.dgv_Proceso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Proceso.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column6,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgv_Proceso.Location = new System.Drawing.Point(313, 66);
            this.dgv_Proceso.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_Proceso.Name = "dgv_Proceso";
            this.dgv_Proceso.ReadOnly = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.dgv_Proceso.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Proceso.RowTemplate.Height = 24;
            this.dgv_Proceso.Size = new System.Drawing.Size(1008, 538);
            this.dgv_Proceso.TabIndex = 19;
            this.dgv_Proceso.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgv_Proceso_MouseClick_1);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Num Proceso";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Procesos";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Prioridad Proceso";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "ID";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Memoria Fisica";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Memoria Virtual";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1333, 615);
            this.Controls.Add(this.dgv_Proceso);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconCerrar)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Proceso)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox IconMin;
        private System.Windows.Forms.PictureBox IconCerrar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnActualizar;
        private System.Windows.Forms.Label lbl_Contador;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button Btn_Detener;
        private System.Windows.Forms.DataGridView dgv_Proceso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}

