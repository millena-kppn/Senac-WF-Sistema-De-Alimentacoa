namespace SenacAlimentacao
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            //ocultar o formulário FrmLogin
            this.Hide();
            //criar uma instância do formulário FrmPrincipal
            var frmPrincipal = new FrmPrincipal();
            //exibir o formulário FrmPrincipal
            frmPrincipal.Show();
        }

        private void btnFecharLogin_Click(object sender, EventArgs e)
        {
            //fecha a tela de login
            Close();
            //encerra o aplicativo
            Application.Exit();
        }
    }
}
