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
        //Declaracion de variable string para obtener el nombre del proceso en la tabla para su eliminacion
        string Str_Obt_Proc;
        public Form1()
        {
            InitializeComponent();
            //Activacion del timer que actualizara la tabla
            ActualizarTabla();
            timer1.Enabled = true;
            
        }

        private void ActualizarTabla()
        {
            //limpieza del datagrid
            dgv_Proceso.Rows.Clear();
            //creacion columnas con sus respectivos nombres
            dgv_Proceso.Columns[0].Name = "Num. Procesos";
            dgv_Proceso.Columns[1].Name = "Procesos";
            dgv_Proceso.Columns[2].Name = "ID";
            dgv_Proceso.Columns[3].Name = "Memoria Fisica";
            dgv_Proceso.Columns[4].Name = "Memoria Virtual";
            dgv_Proceso.Columns[5].Name = "CPU";

            //Propiedad para autoajustar el tamaño de las celdas segun su contenido
            dgv_Proceso.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //Propiedad para que el usuario seleccione solamente filas en la tabla y no celdas sueltas
            dgv_Proceso.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //Propiedad para que el usuario no pueda seleccionar mas de una fila
            dgv_Proceso.MultiSelect = false;

            //Declaracion de la variable que sera un contador para el total de procesos
            int Int_Cant_Proc = 1;


            foreach (Process Proc_Proceso in Process.GetProcesses())
            {
                //Ingreso de los datos en el datagrid
                dgv_Proceso.Rows.Add(Int_Cant_Proc, Proc_Proceso.ProcessName, Proc_Proceso.Id, Proc_Proceso.WorkingSet64,
                    Proc_Proceso.VirtualMemorySize64, Proc_Proceso.SessionId);
                //aumento en 1 de la variable
                Int_Cant_Proc += 1;
            }
            //El label muestra la cantidad de procesos actuales
            lbl_Contador.Text = "Procesos Actuales: " + (Int_Cant_Proc - 1);    //  cant de procesos   


        } //fin metodo ActualizarTabla


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



        private void BtnActualizar_Click(object sender, EventArgs e)
        {


            ActualizarTabla(); 
        }

        private void dgv_Proceso_MouseClick(object sender, MouseEventArgs e)
        {
            //La variable obtiene el Nombre del Proceso de la Tabla al hacerle clic
            Str_Obt_Proc = dgv_Proceso.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void Btn_Detener_Click(object sender, EventArgs e)
        {
            try 
            {
                foreach(Process proceso in Process.GetProcesses())
                {
                    if (proceso.ProcessName == Str_Obt_Proc)
                    {
                        proceso.Kill();
                    }
                }

            }
            catch (Exception x) 
            {
                MessageBox.Show("No se ha seleccionado ningun proceso para detener." + x, "Error al Detener Proceso", MessageBoxButtons.OK);
            }
        }

        private void dgv_Proceso_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
