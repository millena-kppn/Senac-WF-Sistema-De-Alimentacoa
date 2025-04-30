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
            //ocultar o formul�rio FrmLogin
            this.Hide();
            //criar uma inst�ncia do formul�rio FrmPrincipal
            var frmPrincipal = new FrmPrincipal();
            //exibir o formul�rio FrmPrincipal
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
