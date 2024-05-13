using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace check_station
{
    public partial class form_check_station : Form
    {
        public form_check_station()
        {
            InitializeComponent();
        }

        private void btnCheckStation_Click(object sender, EventArgs e)
        {
            GetDeviceInfo();
        }

        private void GetDeviceInfo()
        {
            string modelo = ExecuteADBCommand("shell getprop ro.product.model").Trim();
            string numeroSerie = ExecuteADBCommand("shell getprop ro.serialno").Trim();
            string versao = ExecuteADBCommand("shell getprop ro.build.version.release").Trim();
            string fabricante = ExecuteADBCommand("shell getprop ro.product.manufacturer").Trim();
            string sdkAndroid = ExecuteADBCommand("shell getprop ro.build.version.sdk").Trim();
            string operadoraNome = ExecuteADBCommand("shell getprop gsm.operator.alpha").Trim();

            dataGridView1.Rows.Add(modelo, versao, numeroSerie, fabricante, sdkAndroid, operadoraNome);
        }

        private string ExecuteADBCommand(string command)
        {
            try
            {
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = @"C:\Users\rickb\OneDrive\Área de Trabalho\platform-tools\adb.exe";
                startInfo.Arguments = command;
                startInfo.RedirectStandardOutput = true;
                startInfo.UseShellExecute = false;
                startInfo.CreateNoWindow = true;

                using (Process process = Process.Start(startInfo))
                {
                    if (process != null)
                    {
                        using (StreamReader reader = process.StandardOutput)
                        {
                            return reader.ReadToEnd();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message);
            }

            return "";
        }
    }
}
