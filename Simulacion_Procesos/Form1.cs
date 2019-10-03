using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;



namespace Simulacion_Procesos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Activacion del timer que actualizara la tabla
            timer1.Enabled = true;
            
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void IconCerrar_Click(object sender, EventArgs e){
            Application.Exit();
        }

        private void PictureBox1_Click(object sender, EventArgs e){
            if (this.WindowState == FormWindowState.Normal){
                this.Location = Screen.PrimaryScreen.WorkingArea.Location;
                this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            }else{
                this.WindowState = FormWindowState.Normal;
            }

        }

        private void Panel1_MouseDown(object sender, MouseEventArgs e){
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void IconMin_Click(object sender, EventArgs e){
            this.WindowState = FormWindowState.Minimized;
        }

        private void TxtActualizar_Click(object sender, EventArgs e)
        {
           

            lstProcesses.Items.Clear();
            lst_id.Items.Clear();
            lst_memoriafisica.Items.Clear();
            lst_memoriavirtual.Items.Clear();
            lst_CPU.Items.Clear();

            int id = 1;
            foreach (Process p in Process.GetProcesses())
            {
                lstProcesses.Items.Add(id + ":" + p.ProcessName); // nombre del proceso
                lst_id.Items.Add(id + ": " + p.Id);// id del proceso
                lst_memoriafisica.Items.Add(id + ": " + p.WorkingSet64);// RAM del proceso
                lst_memoriavirtual.Items.Add(id + ": " + p.VirtualMemorySize64); // MEmoria virtual del proceso
                lst_CPU.Items.Add(id + ": " + p.SessionId); // CPU que usa el proceso

            }

        }
    }
}
