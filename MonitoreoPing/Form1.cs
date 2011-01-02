using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace MonitoreoPing
{
    public partial class Form1 : Form
    {
        EnvioPing ctrlping;
        string server;
        private SqlCommand comando;
        private SqlConnection conexion;
        public Form1()
        {
            InitializeComponent();
            conexion =new SqlConnection(MonitoreoPing.Properties.Settings.Default.Conexion);
            comando = new SqlCommand("INSERT INTO LogPing (Host,Respuesta,Fecha) VALUES (@Host,@Respuesta,GETDATE())", conexion);
            comando.Parameters.Add("Host", System.Data.SqlDbType.NVarChar);
            comando.Parameters.Add("Respuesta", System.Data.SqlDbType.Bit );
        }

        private void btniniciar_Click(object sender, EventArgs e)
        {
            if (ctrlping == null)
            {
                timerchequeo.Interval = MonitoreoPing.Properties.Settings.Default.TiempoPing * 1000;
                timerchequeo.Start();
                server = MonitoreoPing.Properties.Settings.Default.Servidor;
                ctrlping = new EnvioPing(server );
            }
        }

        private void timerchequeo_Tick(object sender, EventArgs e)
        {
            bool ejecucion;
            ejecucion=ctrlping.Ejecutar();
            InsertarRegistro(DateTime.Now, ejecucion, server);
        }

        private void btndetener_Click(object sender, EventArgs e)
        {
            timerchequeo.Stop();
        }
        private void InsertarRegistro(DateTime horaEjecucion, bool resultado, string host)
        {
            conexion.Open();
            comando.Parameters[0].Value = host;
            comando.Parameters[1].Value = resultado;
            //comando.Parameters[2].Value = horaEjecucion;
            comando.ExecuteNonQuery();
            conexion.Close();
        }
    }
}
