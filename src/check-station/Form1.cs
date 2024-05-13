namespace check_station
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbxUsuario.Items.Add("admin");
        }

        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtSenha.Text != "")
            {
                if (txtSenha.Text == "admin" && Convert.ToString(cbxUsuario.SelectedItem) == "admin")
                {
                    btnEntrar.Visible = true;
                }
            }
            else if (e.KeyCode == Keys.Enter)
            {
                txtSenha.Text = "";
                cbxUsuario.Text = "Selecione";
                MessageBox.Show("Usuário inválido ou senha incorreta.");
            }
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            form_hub_application f_hub_application = new form_hub_application();
            f_hub_application.TopLevel = false;
            panel1.Controls.Add(f_hub_application);
            f_hub_application.BringToFront();
            f_hub_application.Show();
        }

        private void cbxUsuario_SelectedValueChanged(object sender, EventArgs e)
        {
            txtSenha.Focus();
        }
    }
}
